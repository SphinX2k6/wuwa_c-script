using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BC6 RID: 3014
	public sealed class PartUpdateInfo : IMessage<PartUpdateInfo>, IMessage, IEquatable<PartUpdateInfo>, IDeepCloneable<PartUpdateInfo>, IBufferMessage
	{
		// Token: 0x06010547 RID: 66887 RVA: 0x00261DEA File Offset: 0x0025FFEA
		[NullableContext(1)]
		public static PartUpdateInfo Create()
		{
			return new PartUpdateInfo();
		}

		// Token: 0x1700358E RID: 13710
		// (get) Token: 0x06010548 RID: 66888 RVA: 0x00261DF1 File Offset: 0x0025FFF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartUpdateInfo> Parser
		{
			get
			{
				return PartUpdateInfo._parser;
			}
		}

		// Token: 0x1700358F RID: 13711
		// (get) Token: 0x06010549 RID: 66889 RVA: 0x00261DF8 File Offset: 0x0025FFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003590 RID: 13712
		// (get) Token: 0x0601054A RID: 66890 RVA: 0x00261DFB File Offset: 0x0025FFFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartUpdateInfo.Descriptor;
			}
		}

		// Token: 0x0601054B RID: 66891 RVA: 0x00261E02 File Offset: 0x00260002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateInfo()
		{
		}

		// Token: 0x0601054C RID: 66892 RVA: 0x00261E0A File Offset: 0x0026000A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateInfo(PartUpdateInfo other) : this()
		{
			this.partId_ = other.partId_;
			this.activated_ = other.activated_;
			this.reset_ = other.reset_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601054D RID: 66893 RVA: 0x00261E47 File Offset: 0x00260047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateInfo Clone()
		{
			return new PartUpdateInfo(this);
		}

		// Token: 0x17003591 RID: 13713
		// (get) Token: 0x0601054E RID: 66894 RVA: 0x00261E4F File Offset: 0x0026004F
		// (set) Token: 0x0601054F RID: 66895 RVA: 0x00261E57 File Offset: 0x00260057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PartId
		{
			get
			{
				return this.partId_;
			}
			set
			{
				this.partId_ = value;
			}
		}

		// Token: 0x17003592 RID: 13714
		// (get) Token: 0x06010550 RID: 66896 RVA: 0x00261E60 File Offset: 0x00260060
		// (set) Token: 0x06010551 RID: 66897 RVA: 0x00261E68 File Offset: 0x00260068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Activated
		{
			get
			{
				return this.activated_;
			}
			set
			{
				this.activated_ = value;
			}
		}

		// Token: 0x17003593 RID: 13715
		// (get) Token: 0x06010552 RID: 66898 RVA: 0x00261E71 File Offset: 0x00260071
		// (set) Token: 0x06010553 RID: 66899 RVA: 0x00261E79 File Offset: 0x00260079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Reset
		{
			get
			{
				return this.reset_;
			}
			set
			{
				this.reset_ = value;
			}
		}

		// Token: 0x06010554 RID: 66900 RVA: 0x00261E82 File Offset: 0x00260082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartUpdateInfo);
		}

		// Token: 0x06010555 RID: 66901 RVA: 0x00261E90 File Offset: 0x00260090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PartUpdateInfo other)
		{
			return other != null && (other == this || (this.PartId == other.PartId && this.Activated == other.Activated && this.Reset == other.Reset && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010556 RID: 66902 RVA: 0x00261EEC File Offset: 0x002600EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PartId != 0)
			{
				num ^= this.PartId.GetHashCode();
			}
			if (this.Activated)
			{
				num ^= this.Activated.GetHashCode();
			}
			if (this.Reset)
			{
				num ^= this.Reset.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010557 RID: 66903 RVA: 0x00261F5D File Offset: 0x0026015D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010558 RID: 66904 RVA: 0x00261F6A File Offset: 0x0026016A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010559 RID: 66905 RVA: 0x00261F74 File Offset: 0x00260174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PartId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PartId);
			}
			if (this.Activated)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Activated);
			}
			if (this.Reset)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Reset);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601055A RID: 66906 RVA: 0x00261FE8 File Offset: 0x002601E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PartId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PartId);
			}
			if (this.Activated)
			{
				num += 2;
			}
			if (this.Reset)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601055B RID: 66907 RVA: 0x00262040 File Offset: 0x00260240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PartUpdateInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PartId != 0)
			{
				this.PartId = other.PartId;
			}
			if (other.Activated)
			{
				this.Activated = other.Activated;
			}
			if (other.Reset)
			{
				this.Reset = other.Reset;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601055C RID: 66908 RVA: 0x002620A4 File Offset: 0x002602A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601055D RID: 66909 RVA: 0x002620B0 File Offset: 0x002602B0
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
							this.Reset = input.ReadBool();
						}
					}
					else
					{
						this.Activated = input.ReadBool();
					}
				}
				else
				{
					this.PartId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040067C1 RID: 26561
		private static readonly MessageParser<PartUpdateInfo> _parser = new MessageParser<PartUpdateInfo>(() => new PartUpdateInfo());

		// Token: 0x040067C2 RID: 26562
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067C3 RID: 26563
		public const int PartIdFieldNumber = 1;

		// Token: 0x040067C4 RID: 26564
		private int partId_;

		// Token: 0x040067C5 RID: 26565
		public const int ActivatedFieldNumber = 2;

		// Token: 0x040067C6 RID: 26566
		private bool activated_;

		// Token: 0x040067C7 RID: 26567
		public const int ResetFieldNumber = 3;

		// Token: 0x040067C8 RID: 26568
		private bool reset_;
	}
}
