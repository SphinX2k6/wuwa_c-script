using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011D9 RID: 4569
	public sealed class ScratchCardRewardData : IMessage<ScratchCardRewardData>, IMessage, IEquatable<ScratchCardRewardData>, IDeepCloneable<ScratchCardRewardData>, IBufferMessage
	{
		// Token: 0x06018631 RID: 99889 RVA: 0x0038C91D File Offset: 0x0038AB1D
		[NullableContext(1)]
		public static ScratchCardRewardData Create()
		{
			return new ScratchCardRewardData();
		}

		// Token: 0x1700522E RID: 21038
		// (get) Token: 0x06018632 RID: 99890 RVA: 0x0038C924 File Offset: 0x0038AB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ScratchCardRewardData> Parser
		{
			get
			{
				return ScratchCardRewardData._parser;
			}
		}

		// Token: 0x1700522F RID: 21039
		// (get) Token: 0x06018633 RID: 99891 RVA: 0x0038C92B File Offset: 0x0038AB2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005230 RID: 21040
		// (get) Token: 0x06018634 RID: 99892 RVA: 0x0038C92E File Offset: 0x0038AB2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScratchCardRewardData.Descriptor;
			}
		}

		// Token: 0x06018635 RID: 99893 RVA: 0x0038C935 File Offset: 0x0038AB35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardRewardData()
		{
		}

		// Token: 0x06018636 RID: 99894 RVA: 0x0038C93D File Offset: 0x0038AB3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardRewardData(ScratchCardRewardData other) : this()
		{
			this.itemId_ = other.itemId_;
			this.num_ = other.num_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018637 RID: 99895 RVA: 0x0038C96E File Offset: 0x0038AB6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardRewardData Clone()
		{
			return new ScratchCardRewardData(this);
		}

		// Token: 0x17005231 RID: 21041
		// (get) Token: 0x06018638 RID: 99896 RVA: 0x0038C976 File Offset: 0x0038AB76
		// (set) Token: 0x06018639 RID: 99897 RVA: 0x0038C97E File Offset: 0x0038AB7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17005232 RID: 21042
		// (get) Token: 0x0601863A RID: 99898 RVA: 0x0038C987 File Offset: 0x0038AB87
		// (set) Token: 0x0601863B RID: 99899 RVA: 0x0038C98F File Offset: 0x0038AB8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x0601863C RID: 99900 RVA: 0x0038C998 File Offset: 0x0038AB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScratchCardRewardData);
		}

		// Token: 0x0601863D RID: 99901 RVA: 0x0038C9A6 File Offset: 0x0038ABA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScratchCardRewardData other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Num == other.Num && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601863E RID: 99902 RVA: 0x0038C9E4 File Offset: 0x0038ABE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601863F RID: 99903 RVA: 0x0038CA3C File Offset: 0x0038AC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018640 RID: 99904 RVA: 0x0038CA49 File Offset: 0x0038AC49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018641 RID: 99905 RVA: 0x0038CA54 File Offset: 0x0038AC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Num);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018642 RID: 99906 RVA: 0x0038CAAC File Offset: 0x0038ACAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018643 RID: 99907 RVA: 0x0038CB04 File Offset: 0x0038AD04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScratchCardRewardData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Num != 0)
			{
				this.Num = other.Num;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018644 RID: 99908 RVA: 0x0038CB54 File Offset: 0x0038AD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018645 RID: 99909 RVA: 0x0038CB60 File Offset: 0x0038AD60
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
						this.Num = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040090DA RID: 37082
		private static readonly MessageParser<ScratchCardRewardData> _parser = new MessageParser<ScratchCardRewardData>(() => new ScratchCardRewardData());

		// Token: 0x040090DB RID: 37083
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090DC RID: 37084
		public const int ItemIdFieldNumber = 1;

		// Token: 0x040090DD RID: 37085
		private int itemId_;

		// Token: 0x040090DE RID: 37086
		public const int NumFieldNumber = 2;

		// Token: 0x040090DF RID: 37087
		private int num_;
	}
}
