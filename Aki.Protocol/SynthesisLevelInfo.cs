using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001311 RID: 4881
	public sealed class SynthesisLevelInfo : IMessage<SynthesisLevelInfo>, IMessage, IEquatable<SynthesisLevelInfo>, IDeepCloneable<SynthesisLevelInfo>, IBufferMessage
	{
		// Token: 0x06019F11 RID: 106257 RVA: 0x003C4EF7 File Offset: 0x003C30F7
		[NullableContext(1)]
		public static SynthesisLevelInfo Create()
		{
			return new SynthesisLevelInfo();
		}

		// Token: 0x1700577C RID: 22396
		// (get) Token: 0x06019F12 RID: 106258 RVA: 0x003C4EFE File Offset: 0x003C30FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700577D RID: 22397
		// (get) Token: 0x06019F13 RID: 106259 RVA: 0x003C4F01 File Offset: 0x003C3101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SynthesisLevelInfo.Descriptor;
			}
		}

		// Token: 0x06019F14 RID: 106260 RVA: 0x003C4F08 File Offset: 0x003C3108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelInfo()
		{
		}

		// Token: 0x06019F15 RID: 106261 RVA: 0x003C4F10 File Offset: 0x003C3110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelInfo(SynthesisLevelInfo other) : this()
		{
			this.level_ = other.level_;
			this.totalProficiency_ = other.totalProficiency_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019F16 RID: 106262 RVA: 0x003C4F41 File Offset: 0x003C3141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelInfo Clone()
		{
			return new SynthesisLevelInfo(this);
		}

		// Token: 0x1700577E RID: 22398
		// (get) Token: 0x06019F17 RID: 106263 RVA: 0x003C4F49 File Offset: 0x003C3149
		// (set) Token: 0x06019F18 RID: 106264 RVA: 0x003C4F51 File Offset: 0x003C3151
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

		// Token: 0x1700577F RID: 22399
		// (get) Token: 0x06019F19 RID: 106265 RVA: 0x003C4F5A File Offset: 0x003C315A
		// (set) Token: 0x06019F1A RID: 106266 RVA: 0x003C4F62 File Offset: 0x003C3162
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

		// Token: 0x06019F1B RID: 106267 RVA: 0x003C4F6B File Offset: 0x003C316B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SynthesisLevelInfo);
		}

		// Token: 0x06019F1C RID: 106268 RVA: 0x003C4F79 File Offset: 0x003C3179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SynthesisLevelInfo other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.TotalProficiency == other.TotalProficiency && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019F1D RID: 106269 RVA: 0x003C4FB8 File Offset: 0x003C31B8
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

		// Token: 0x06019F1E RID: 106270 RVA: 0x003C5010 File Offset: 0x003C3210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019F1F RID: 106271 RVA: 0x003C501D File Offset: 0x003C321D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019F20 RID: 106272 RVA: 0x003C5028 File Offset: 0x003C3228
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

		// Token: 0x06019F21 RID: 106273 RVA: 0x003C5080 File Offset: 0x003C3280
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

		// Token: 0x06019F22 RID: 106274 RVA: 0x003C50D8 File Offset: 0x003C32D8
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

		// Token: 0x06019F23 RID: 106275 RVA: 0x003C5128 File Offset: 0x003C3328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019F24 RID: 106276 RVA: 0x003C5134 File Offset: 0x003C3334
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

		// Token: 0x0400979F RID: 38815
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097A0 RID: 38816
		public const int LevelFieldNumber = 1;

		// Token: 0x040097A1 RID: 38817
		private int level_;

		// Token: 0x040097A2 RID: 38818
		public const int TotalProficiencyFieldNumber = 2;

		// Token: 0x040097A3 RID: 38819
		private int totalProficiency_;
	}
}
