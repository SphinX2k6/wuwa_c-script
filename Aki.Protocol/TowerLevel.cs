using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013C2 RID: 5058
	public sealed class TowerLevel : IMessage<TowerLevel>, IMessage, IEquatable<TowerLevel>, IDeepCloneable<TowerLevel>, IBufferMessage
	{
		// Token: 0x0601AD48 RID: 109896 RVA: 0x003E3DAC File Offset: 0x003E1FAC
		[NullableContext(1)]
		public static TowerLevel Create()
		{
			return new TowerLevel();
		}

		// Token: 0x17005A7C RID: 23164
		// (get) Token: 0x0601AD49 RID: 109897 RVA: 0x003E3DB3 File Offset: 0x003E1FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A7D RID: 23165
		// (get) Token: 0x0601AD4A RID: 109898 RVA: 0x003E3DB6 File Offset: 0x003E1FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerLevel.Descriptor;
			}
		}

		// Token: 0x0601AD4B RID: 109899 RVA: 0x003E3DBD File Offset: 0x003E1FBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerLevel()
		{
		}

		// Token: 0x0601AD4C RID: 109900 RVA: 0x003E3DC5 File Offset: 0x003E1FC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerLevel(TowerLevel other) : this()
		{
			this.starByte_ = other.starByte_;
			this.costTime_ = other.costTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AD4D RID: 109901 RVA: 0x003E3DF6 File Offset: 0x003E1FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerLevel Clone()
		{
			return new TowerLevel(this);
		}

		// Token: 0x17005A7E RID: 23166
		// (get) Token: 0x0601AD4E RID: 109902 RVA: 0x003E3DFE File Offset: 0x003E1FFE
		// (set) Token: 0x0601AD4F RID: 109903 RVA: 0x003E3E06 File Offset: 0x003E2006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StarByte
		{
			get
			{
				return this.starByte_;
			}
			set
			{
				this.starByte_ = value;
			}
		}

		// Token: 0x17005A7F RID: 23167
		// (get) Token: 0x0601AD50 RID: 109904 RVA: 0x003E3E0F File Offset: 0x003E200F
		// (set) Token: 0x0601AD51 RID: 109905 RVA: 0x003E3E17 File Offset: 0x003E2017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CostTime
		{
			get
			{
				return this.costTime_;
			}
			set
			{
				this.costTime_ = value;
			}
		}

		// Token: 0x0601AD52 RID: 109906 RVA: 0x003E3E20 File Offset: 0x003E2020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerLevel);
		}

		// Token: 0x0601AD53 RID: 109907 RVA: 0x003E3E2E File Offset: 0x003E202E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerLevel other)
		{
			return other != null && (other == this || (this.StarByte == other.StarByte && this.CostTime == other.CostTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AD54 RID: 109908 RVA: 0x003E3E6C File Offset: 0x003E206C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StarByte != 0)
			{
				num ^= this.StarByte.GetHashCode();
			}
			if (this.CostTime != 0)
			{
				num ^= this.CostTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AD55 RID: 109909 RVA: 0x003E3EC4 File Offset: 0x003E20C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AD56 RID: 109910 RVA: 0x003E3ED1 File Offset: 0x003E20D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AD57 RID: 109911 RVA: 0x003E3EDC File Offset: 0x003E20DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StarByte != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.StarByte);
			}
			if (this.CostTime != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CostTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AD58 RID: 109912 RVA: 0x003E3F34 File Offset: 0x003E2134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StarByte != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StarByte);
			}
			if (this.CostTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CostTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AD59 RID: 109913 RVA: 0x003E3F8C File Offset: 0x003E218C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerLevel other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StarByte != 0)
			{
				this.StarByte = other.StarByte;
			}
			if (other.CostTime != 0)
			{
				this.CostTime = other.CostTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AD5A RID: 109914 RVA: 0x003E3FDC File Offset: 0x003E21DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AD5B RID: 109915 RVA: 0x003E3FE8 File Offset: 0x003E21E8
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
						this.CostTime = input.ReadInt32();
					}
				}
				else
				{
					this.StarByte = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009BB6 RID: 39862
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BB7 RID: 39863
		public const int StarByteFieldNumber = 1;

		// Token: 0x04009BB8 RID: 39864
		private int starByte_;

		// Token: 0x04009BB9 RID: 39865
		public const int CostTimeFieldNumber = 2;

		// Token: 0x04009BBA RID: 39866
		private int costTime_;
	}
}
