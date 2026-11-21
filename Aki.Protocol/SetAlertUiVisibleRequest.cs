using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001201 RID: 4609
	[NetMessage(EMessageId.SetAlertUiVisibleRequest)]
	public sealed class SetAlertUiVisibleRequest : IMessage<SetAlertUiVisibleRequest>, IMessage, IEquatable<SetAlertUiVisibleRequest>, IDeepCloneable<SetAlertUiVisibleRequest>, IBufferMessage
	{
		// Token: 0x06018A15 RID: 100885 RVA: 0x00397C88 File Offset: 0x00395E88
		[NullableContext(1)]
		public static SetAlertUiVisibleRequest Create()
		{
			return new SetAlertUiVisibleRequest();
		}

		// Token: 0x17005333 RID: 21299
		// (get) Token: 0x06018A16 RID: 100886 RVA: 0x00397C8F File Offset: 0x00395E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005334 RID: 21300
		// (get) Token: 0x06018A17 RID: 100887 RVA: 0x00397C92 File Offset: 0x00395E92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetAlertUiVisibleRequest.Descriptor;
			}
		}

		// Token: 0x06018A18 RID: 100888 RVA: 0x00397C99 File Offset: 0x00395E99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAlertUiVisibleRequest()
		{
		}

		// Token: 0x06018A19 RID: 100889 RVA: 0x00397CA1 File Offset: 0x00395EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAlertUiVisibleRequest(SetAlertUiVisibleRequest other) : this()
		{
			this.areaId_ = other.areaId_;
			this.visible_ = other.visible_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018A1A RID: 100890 RVA: 0x00397CD2 File Offset: 0x00395ED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAlertUiVisibleRequest Clone()
		{
			return new SetAlertUiVisibleRequest(this);
		}

		// Token: 0x17005335 RID: 21301
		// (get) Token: 0x06018A1B RID: 100891 RVA: 0x00397CDA File Offset: 0x00395EDA
		// (set) Token: 0x06018A1C RID: 100892 RVA: 0x00397CE2 File Offset: 0x00395EE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x17005336 RID: 21302
		// (get) Token: 0x06018A1D RID: 100893 RVA: 0x00397CEB File Offset: 0x00395EEB
		// (set) Token: 0x06018A1E RID: 100894 RVA: 0x00397CF3 File Offset: 0x00395EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Visible
		{
			get
			{
				return this.visible_;
			}
			set
			{
				this.visible_ = value;
			}
		}

		// Token: 0x06018A1F RID: 100895 RVA: 0x00397CFC File Offset: 0x00395EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetAlertUiVisibleRequest);
		}

		// Token: 0x06018A20 RID: 100896 RVA: 0x00397D0A File Offset: 0x00395F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetAlertUiVisibleRequest other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && this.Visible == other.Visible && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018A21 RID: 100897 RVA: 0x00397D48 File Offset: 0x00395F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaId != 0)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this.Visible)
			{
				num ^= this.Visible.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018A22 RID: 100898 RVA: 0x00397DA0 File Offset: 0x00395FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018A23 RID: 100899 RVA: 0x00397DAD File Offset: 0x00395FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018A24 RID: 100900 RVA: 0x00397DB8 File Offset: 0x00395FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.AreaId);
			}
			if (this.Visible)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.Visible);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018A25 RID: 100901 RVA: 0x00397E14 File Offset: 0x00396014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaId);
			}
			if (this.Visible)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018A26 RID: 100902 RVA: 0x00397E60 File Offset: 0x00396060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetAlertUiVisibleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaId != 0)
			{
				this.AreaId = other.AreaId;
			}
			if (other.Visible)
			{
				this.Visible = other.Visible;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018A27 RID: 100903 RVA: 0x00397EB0 File Offset: 0x003960B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018A28 RID: 100904 RVA: 0x00397EBC File Offset: 0x003960BC
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
				if (num != 56U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Visible = input.ReadBool();
					}
				}
				else
				{
					this.AreaId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400926E RID: 37486
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400926F RID: 37487
		public const int AreaIdFieldNumber = 7;

		// Token: 0x04009270 RID: 37488
		private int areaId_;

		// Token: 0x04009271 RID: 37489
		public const int VisibleFieldNumber = 9;

		// Token: 0x04009272 RID: 37490
		private bool visible_;
	}
}
