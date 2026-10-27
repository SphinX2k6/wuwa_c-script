using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008E1 RID: 2273
	[NetMessage(EMessageId.KurotatoWeaponUpdateNotify)]
	public sealed class KurotatoWeaponUpdateNotify : IMessage<KurotatoWeaponUpdateNotify>, IMessage, IEquatable<KurotatoWeaponUpdateNotify>, IDeepCloneable<KurotatoWeaponUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600C92C RID: 51500 RVA: 0x001DBA31 File Offset: 0x001D9C31
		[NullableContext(1)]
		public static KurotatoWeaponUpdateNotify Create()
		{
			return new KurotatoWeaponUpdateNotify();
		}

		// Token: 0x170028A4 RID: 10404
		// (get) Token: 0x0600C92D RID: 51501 RVA: 0x001DBA38 File Offset: 0x001D9C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028A5 RID: 10405
		// (get) Token: 0x0600C92E RID: 51502 RVA: 0x001DBA3B File Offset: 0x001D9C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoWeaponUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600C92F RID: 51503 RVA: 0x001DBA42 File Offset: 0x001D9C42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponUpdateNotify()
		{
		}

		// Token: 0x0600C930 RID: 51504 RVA: 0x001DBA4A File Offset: 0x001D9C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponUpdateNotify(KurotatoWeaponUpdateNotify other) : this()
		{
			this.panelPbData_ = ((other.panelPbData_ != null) ? other.panelPbData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C931 RID: 51505 RVA: 0x001DBA7F File Offset: 0x001D9C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponUpdateNotify Clone()
		{
			return new KurotatoWeaponUpdateNotify(this);
		}

		// Token: 0x170028A6 RID: 10406
		// (get) Token: 0x0600C932 RID: 51506 RVA: 0x001DBA87 File Offset: 0x001D9C87
		// (set) Token: 0x0600C933 RID: 51507 RVA: 0x001DBA8F File Offset: 0x001D9C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponPanelPbData PanelPbData
		{
			get
			{
				return this.panelPbData_;
			}
			set
			{
				this.panelPbData_ = value;
			}
		}

		// Token: 0x0600C934 RID: 51508 RVA: 0x001DBA98 File Offset: 0x001D9C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoWeaponUpdateNotify);
		}

		// Token: 0x0600C935 RID: 51509 RVA: 0x001DBAA6 File Offset: 0x001D9CA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoWeaponUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PanelPbData, other.PanelPbData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C936 RID: 51510 RVA: 0x001DBADC File Offset: 0x001D9CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.panelPbData_ != null)
			{
				num ^= this.PanelPbData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C937 RID: 51511 RVA: 0x001DBB18 File Offset: 0x001D9D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C938 RID: 51512 RVA: 0x001DBB25 File Offset: 0x001D9D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C939 RID: 51513 RVA: 0x001DBB2E File Offset: 0x001D9D2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.panelPbData_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.PanelPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C93A RID: 51514 RVA: 0x001DBB60 File Offset: 0x001D9D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.panelPbData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PanelPbData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C93B RID: 51515 RVA: 0x001DBBA0 File Offset: 0x001D9DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoWeaponUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.panelPbData_ != null)
			{
				if (this.panelPbData_ == null)
				{
					this.PanelPbData = new KurotatoWeaponPanelPbData();
				}
				this.PanelPbData.MergeFrom(other.PanelPbData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C93C RID: 51516 RVA: 0x001DBBF4 File Offset: 0x001D9DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C93D RID: 51517 RVA: 0x001DBC00 File Offset: 0x001D9E00
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.panelPbData_ == null)
					{
						this.PanelPbData = new KurotatoWeaponPanelPbData();
					}
					input.ReadMessage(this.PanelPbData);
				}
			}
		}

		// Token: 0x040055E1 RID: 21985
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055E2 RID: 21986
		public const int PanelPbDataFieldNumber = 3;

		// Token: 0x040055E3 RID: 21987
		private KurotatoWeaponPanelPbData panelPbData_;
	}
}
