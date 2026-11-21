using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200058E RID: 1422
	public sealed class FlagToBoxInfo : IMessage<FlagToBoxInfo>, IMessage, IEquatable<FlagToBoxInfo>, IDeepCloneable<FlagToBoxInfo>, IBufferMessage
	{
		// Token: 0x0600840B RID: 33803 RVA: 0x0013E059 File Offset: 0x0013C259
		[NullableContext(1)]
		public static FlagToBoxInfo Create()
		{
			return new FlagToBoxInfo();
		}

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x0600840C RID: 33804 RVA: 0x0013E060 File Offset: 0x0013C260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FlagToBoxInfo> Parser
		{
			get
			{
				return FlagToBoxInfo._parser;
			}
		}

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x0600840D RID: 33805 RVA: 0x0013E067 File Offset: 0x0013C267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x0600840E RID: 33806 RVA: 0x0013E06A File Offset: 0x0013C26A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagToBoxInfo.Descriptor;
			}
		}

		// Token: 0x0600840F RID: 33807 RVA: 0x0013E071 File Offset: 0x0013C271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagToBoxInfo()
		{
		}

		// Token: 0x06008410 RID: 33808 RVA: 0x0013E079 File Offset: 0x0013C279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagToBoxInfo(FlagToBoxInfo other) : this()
		{
			this.flagId_ = other.flagId_;
			this.boxGetCount_ = other.boxGetCount_;
			this.totalCount_ = other.totalCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008411 RID: 33809 RVA: 0x0013E0B6 File Offset: 0x0013C2B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagToBoxInfo Clone()
		{
			return new FlagToBoxInfo(this);
		}

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x06008412 RID: 33810 RVA: 0x0013E0BE File Offset: 0x0013C2BE
		// (set) Token: 0x06008413 RID: 33811 RVA: 0x0013E0C6 File Offset: 0x0013C2C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FlagId
		{
			get
			{
				return this.flagId_;
			}
			set
			{
				this.flagId_ = value;
			}
		}

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x06008414 RID: 33812 RVA: 0x0013E0CF File Offset: 0x0013C2CF
		// (set) Token: 0x06008415 RID: 33813 RVA: 0x0013E0D7 File Offset: 0x0013C2D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BoxGetCount
		{
			get
			{
				return this.boxGetCount_;
			}
			set
			{
				this.boxGetCount_ = value;
			}
		}

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x06008416 RID: 33814 RVA: 0x0013E0E0 File Offset: 0x0013C2E0
		// (set) Token: 0x06008417 RID: 33815 RVA: 0x0013E0E8 File Offset: 0x0013C2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalCount
		{
			get
			{
				return this.totalCount_;
			}
			set
			{
				this.totalCount_ = value;
			}
		}

		// Token: 0x06008418 RID: 33816 RVA: 0x0013E0F1 File Offset: 0x0013C2F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagToBoxInfo);
		}

		// Token: 0x06008419 RID: 33817 RVA: 0x0013E100 File Offset: 0x0013C300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagToBoxInfo other)
		{
			return other != null && (other == this || (this.FlagId == other.FlagId && this.BoxGetCount == other.BoxGetCount && this.TotalCount == other.TotalCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600841A RID: 33818 RVA: 0x0013E15C File Offset: 0x0013C35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FlagId != 0)
			{
				num ^= this.FlagId.GetHashCode();
			}
			if (this.BoxGetCount != 0)
			{
				num ^= this.BoxGetCount.GetHashCode();
			}
			if (this.TotalCount != 0)
			{
				num ^= this.TotalCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600841B RID: 33819 RVA: 0x0013E1CD File Offset: 0x0013C3CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600841C RID: 33820 RVA: 0x0013E1DA File Offset: 0x0013C3DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600841D RID: 33821 RVA: 0x0013E1E4 File Offset: 0x0013C3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FlagId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FlagId);
			}
			if (this.BoxGetCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BoxGetCount);
			}
			if (this.TotalCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TotalCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600841E RID: 33822 RVA: 0x0013E258 File Offset: 0x0013C458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FlagId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FlagId);
			}
			if (this.BoxGetCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BoxGetCount);
			}
			if (this.TotalCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600841F RID: 33823 RVA: 0x0013E2C8 File Offset: 0x0013C4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagToBoxInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FlagId != 0)
			{
				this.FlagId = other.FlagId;
			}
			if (other.BoxGetCount != 0)
			{
				this.BoxGetCount = other.BoxGetCount;
			}
			if (other.TotalCount != 0)
			{
				this.TotalCount = other.TotalCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008420 RID: 33824 RVA: 0x0013E32C File Offset: 0x0013C52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008421 RID: 33825 RVA: 0x0013E338 File Offset: 0x0013C538
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TotalCount = input.ReadInt32();
						}
					}
					else
					{
						this.BoxGetCount = input.ReadInt32();
					}
				}
				else
				{
					this.FlagId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040041F2 RID: 16882
		private static readonly MessageParser<FlagToBoxInfo> _parser = new MessageParser<FlagToBoxInfo>(() => new FlagToBoxInfo());

		// Token: 0x040041F3 RID: 16883
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041F4 RID: 16884
		public const int FlagIdFieldNumber = 1;

		// Token: 0x040041F5 RID: 16885
		private int flagId_;

		// Token: 0x040041F6 RID: 16886
		public const int BoxGetCountFieldNumber = 2;

		// Token: 0x040041F7 RID: 16887
		private int boxGetCount_;

		// Token: 0x040041F8 RID: 16888
		public const int TotalCountFieldNumber = 3;

		// Token: 0x040041F9 RID: 16889
		private int totalCount_;
	}
}
