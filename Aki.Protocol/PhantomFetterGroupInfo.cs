using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CC0 RID: 3264
	public sealed class PhantomFetterGroupInfo : IMessage<PhantomFetterGroupInfo>, IMessage, IEquatable<PhantomFetterGroupInfo>, IDeepCloneable<PhantomFetterGroupInfo>, IBufferMessage
	{
		// Token: 0x06011B12 RID: 72466 RVA: 0x00297445 File Offset: 0x00295645
		[NullableContext(1)]
		public static PhantomFetterGroupInfo Create()
		{
			return new PhantomFetterGroupInfo();
		}

		// Token: 0x17003A9B RID: 15003
		// (get) Token: 0x06011B13 RID: 72467 RVA: 0x0029744C File Offset: 0x0029564C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomFetterGroupInfo> Parser
		{
			get
			{
				return PhantomFetterGroupInfo._parser;
			}
		}

		// Token: 0x17003A9C RID: 15004
		// (get) Token: 0x06011B14 RID: 72468 RVA: 0x00297453 File Offset: 0x00295653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A9D RID: 15005
		// (get) Token: 0x06011B15 RID: 72469 RVA: 0x00297456 File Offset: 0x00295656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomFetterGroupInfo.Descriptor;
			}
		}

		// Token: 0x06011B16 RID: 72470 RVA: 0x0029745D File Offset: 0x0029565D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterGroupInfo()
		{
		}

		// Token: 0x06011B17 RID: 72471 RVA: 0x00297465 File Offset: 0x00295665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterGroupInfo(PhantomFetterGroupInfo other) : this()
		{
			this.phantomFetterGroupId_ = other.phantomFetterGroupId_;
			this.countNeed_ = other.countNeed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011B18 RID: 72472 RVA: 0x00297496 File Offset: 0x00295696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterGroupInfo Clone()
		{
			return new PhantomFetterGroupInfo(this);
		}

		// Token: 0x17003A9E RID: 15006
		// (get) Token: 0x06011B19 RID: 72473 RVA: 0x0029749E File Offset: 0x0029569E
		// (set) Token: 0x06011B1A RID: 72474 RVA: 0x002974A6 File Offset: 0x002956A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomFetterGroupId
		{
			get
			{
				return this.phantomFetterGroupId_;
			}
			set
			{
				this.phantomFetterGroupId_ = value;
			}
		}

		// Token: 0x17003A9F RID: 15007
		// (get) Token: 0x06011B1B RID: 72475 RVA: 0x002974AF File Offset: 0x002956AF
		// (set) Token: 0x06011B1C RID: 72476 RVA: 0x002974B7 File Offset: 0x002956B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CountNeed
		{
			get
			{
				return this.countNeed_;
			}
			set
			{
				this.countNeed_ = value;
			}
		}

		// Token: 0x06011B1D RID: 72477 RVA: 0x002974C0 File Offset: 0x002956C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomFetterGroupInfo);
		}

		// Token: 0x06011B1E RID: 72478 RVA: 0x002974CE File Offset: 0x002956CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomFetterGroupInfo other)
		{
			return other != null && (other == this || (this.PhantomFetterGroupId == other.PhantomFetterGroupId && this.CountNeed == other.CountNeed && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011B1F RID: 72479 RVA: 0x0029750C File Offset: 0x0029570C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PhantomFetterGroupId != 0)
			{
				num ^= this.PhantomFetterGroupId.GetHashCode();
			}
			if (this.CountNeed != 0)
			{
				num ^= this.CountNeed.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011B20 RID: 72480 RVA: 0x00297564 File Offset: 0x00295764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011B21 RID: 72481 RVA: 0x00297571 File Offset: 0x00295771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011B22 RID: 72482 RVA: 0x0029757C File Offset: 0x0029577C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PhantomFetterGroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PhantomFetterGroupId);
			}
			if (this.CountNeed != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CountNeed);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011B23 RID: 72483 RVA: 0x002975D4 File Offset: 0x002957D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PhantomFetterGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomFetterGroupId);
			}
			if (this.CountNeed != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CountNeed);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011B24 RID: 72484 RVA: 0x0029762C File Offset: 0x0029582C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomFetterGroupInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PhantomFetterGroupId != 0)
			{
				this.PhantomFetterGroupId = other.PhantomFetterGroupId;
			}
			if (other.CountNeed != 0)
			{
				this.CountNeed = other.CountNeed;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011B25 RID: 72485 RVA: 0x0029767C File Offset: 0x0029587C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011B26 RID: 72486 RVA: 0x00297688 File Offset: 0x00295888
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
						this.CountNeed = input.ReadInt32();
					}
				}
				else
				{
					this.PhantomFetterGroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006FA4 RID: 28580
		private static readonly MessageParser<PhantomFetterGroupInfo> _parser = new MessageParser<PhantomFetterGroupInfo>(() => new PhantomFetterGroupInfo());

		// Token: 0x04006FA5 RID: 28581
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FA6 RID: 28582
		public const int PhantomFetterGroupIdFieldNumber = 1;

		// Token: 0x04006FA7 RID: 28583
		private int phantomFetterGroupId_;

		// Token: 0x04006FA8 RID: 28584
		public const int CountNeedFieldNumber = 2;

		// Token: 0x04006FA9 RID: 28585
		private int countNeed_;
	}
}
