using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008D0 RID: 2256
	[NetMessage(EMessageId.KurotatoWeaponUpdateNotify)]
	public sealed class KurotatoWeaponUpdateNotify : IMessage<KurotatoWeaponUpdateNotify>, IMessage, IEquatable<KurotatoWeaponUpdateNotify>, IDeepCloneable<KurotatoWeaponUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600C810 RID: 51216 RVA: 0x001D9755 File Offset: 0x001D7955
		[NullableContext(1)]
		public static KurotatoWeaponUpdateNotify Create()
		{
			return new KurotatoWeaponUpdateNotify();
		}

		// Token: 0x17002865 RID: 10341
		// (get) Token: 0x0600C811 RID: 51217 RVA: 0x001D975C File Offset: 0x001D795C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002866 RID: 10342
		// (get) Token: 0x0600C812 RID: 51218 RVA: 0x001D975F File Offset: 0x001D795F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoWeaponUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600C813 RID: 51219 RVA: 0x001D9766 File Offset: 0x001D7966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponUpdateNotify()
		{
		}

		// Token: 0x0600C814 RID: 51220 RVA: 0x001D976E File Offset: 0x001D796E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponUpdateNotify(KurotatoWeaponUpdateNotify other) : this()
		{
			this.panelPbData_ = ((other.panelPbData_ != null) ? other.panelPbData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C815 RID: 51221 RVA: 0x001D97A3 File Offset: 0x001D79A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponUpdateNotify Clone()
		{
			return new KurotatoWeaponUpdateNotify(this);
		}

		// Token: 0x17002867 RID: 10343
		// (get) Token: 0x0600C816 RID: 51222 RVA: 0x001D97AB File Offset: 0x001D79AB
		// (set) Token: 0x0600C817 RID: 51223 RVA: 0x001D97B3 File Offset: 0x001D79B3
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

		// Token: 0x0600C818 RID: 51224 RVA: 0x001D97BC File Offset: 0x001D79BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoWeaponUpdateNotify);
		}

		// Token: 0x0600C819 RID: 51225 RVA: 0x001D97CA File Offset: 0x001D79CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoWeaponUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PanelPbData, other.PanelPbData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C81A RID: 51226 RVA: 0x001D9800 File Offset: 0x001D7A00
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

		// Token: 0x0600C81B RID: 51227 RVA: 0x001D983C File Offset: 0x001D7A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C81C RID: 51228 RVA: 0x001D9849 File Offset: 0x001D7A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C81D RID: 51229 RVA: 0x001D9852 File Offset: 0x001D7A52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.panelPbData_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.PanelPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C81E RID: 51230 RVA: 0x001D9884 File Offset: 0x001D7A84
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

		// Token: 0x0600C81F RID: 51231 RVA: 0x001D98C4 File Offset: 0x001D7AC4
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

		// Token: 0x0600C820 RID: 51232 RVA: 0x001D9918 File Offset: 0x001D7B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C821 RID: 51233 RVA: 0x001D9924 File Offset: 0x001D7B24
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
				if (num != 58U)
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

		// Token: 0x040055E8 RID: 21992
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055E9 RID: 21993
		public const int PanelPbDataFieldNumber = 7;

		// Token: 0x040055EA RID: 21994
		private KurotatoWeaponPanelPbData panelPbData_;
	}
}
