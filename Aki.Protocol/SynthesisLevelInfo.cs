using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200137E RID: 4990
	public sealed class SynthesisLevelInfo : IMessage<SynthesisLevelInfo>, IMessage, IEquatable<SynthesisLevelInfo>, IDeepCloneable<SynthesisLevelInfo>, IBufferMessage
	{
		// Token: 0x0601A921 RID: 108833 RVA: 0x003DF1B2 File Offset: 0x003DD3B2
		[NullableContext(1)]
		public static SynthesisLevelInfo Create()
		{
			return new SynthesisLevelInfo();
		}

		// Token: 0x170059F6 RID: 23030
		// (get) Token: 0x0601A922 RID: 108834 RVA: 0x003DF1B9 File Offset: 0x003DD3B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059F7 RID: 23031
		// (get) Token: 0x0601A923 RID: 108835 RVA: 0x003DF1BC File Offset: 0x003DD3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SynthesisLevelInfo.Descriptor;
			}
		}

		// Token: 0x0601A924 RID: 108836 RVA: 0x003DF1C3 File Offset: 0x003DD3C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelInfo()
		{
		}

		// Token: 0x0601A925 RID: 108837 RVA: 0x003DF1CB File Offset: 0x003DD3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelInfo(SynthesisLevelInfo other) : this()
		{
			this.level_ = other.level_;
			this.totalProficiency_ = other.totalProficiency_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A926 RID: 108838 RVA: 0x003DF1FC File Offset: 0x003DD3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelInfo Clone()
		{
			return new SynthesisLevelInfo(this);
		}

		// Token: 0x170059F8 RID: 23032
		// (get) Token: 0x0601A927 RID: 108839 RVA: 0x003DF204 File Offset: 0x003DD404
		// (set) Token: 0x0601A928 RID: 108840 RVA: 0x003DF20C File Offset: 0x003DD40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x170059F9 RID: 23033
		// (get) Token: 0x0601A929 RID: 108841 RVA: 0x003DF215 File Offset: 0x003DD415
		// (set) Token: 0x0601A92A RID: 108842 RVA: 0x003DF21D File Offset: 0x003DD41D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalProficiency
		{
			get
			{
				return this.totalProficiency_;
			}
			set
			{
				this.totalProficiency_ = value;
			}
		}

		// Token: 0x0601A92B RID: 108843 RVA: 0x003DF226 File Offset: 0x003DD426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SynthesisLevelInfo);
		}

		// Token: 0x0601A92C RID: 108844 RVA: 0x003DF234 File Offset: 0x003DD434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SynthesisLevelInfo other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.TotalProficiency == other.TotalProficiency && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A92D RID: 108845 RVA: 0x003DF274 File Offset: 0x003DD474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.TotalProficiency != 0)
			{
				num ^= this.TotalProficiency.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A92E RID: 108846 RVA: 0x003DF2CC File Offset: 0x003DD4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A92F RID: 108847 RVA: 0x003DF2D9 File Offset: 0x003DD4D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A930 RID: 108848 RVA: 0x003DF2E4 File Offset: 0x003DD4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Level);
			}
			if (this.TotalProficiency != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TotalProficiency);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A931 RID: 108849 RVA: 0x003DF33C File Offset: 0x003DD53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.TotalProficiency != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalProficiency);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A932 RID: 108850 RVA: 0x003DF394 File Offset: 0x003DD594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SynthesisLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.TotalProficiency != 0)
			{
				this.TotalProficiency = other.TotalProficiency;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A933 RID: 108851 RVA: 0x003DF3E4 File Offset: 0x003DD5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A934 RID: 108852 RVA: 0x003DF3F0 File Offset: 0x003DD5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TotalProficiency = input.ReadInt32();
					}
				}
				else
				{
					this.Level = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009BC1 RID: 39873
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BC2 RID: 39874
		public const int LevelFieldNumber = 1;

		// Token: 0x04009BC3 RID: 39875
		private int level_;

		// Token: 0x04009BC4 RID: 39876
		public const int TotalProficiencyFieldNumber = 2;

		// Token: 0x04009BC5 RID: 39877
		private int totalProficiency_;
	}
}
