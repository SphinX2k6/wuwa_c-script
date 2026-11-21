using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F1F RID: 3871
	[NetMessage(EMessageId.ReviveRequest)]
	public sealed class ReviveRequest : IMessage<ReviveRequest>, IMessage, IEquatable<ReviveRequest>, IDeepCloneable<ReviveRequest>, IBufferMessage
	{
		// Token: 0x06014BEB RID: 84971 RVA: 0x0030336C File Offset: 0x0030156C
		[NullableContext(1)]
		public static ReviveRequest Create()
		{
			return new ReviveRequest();
		}

		// Token: 0x170044FB RID: 17659
		// (get) Token: 0x06014BEC RID: 84972 RVA: 0x00303373 File Offset: 0x00301573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044FC RID: 17660
		// (get) Token: 0x06014BED RID: 84973 RVA: 0x00303376 File Offset: 0x00301576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReviveRequest.Descriptor;
			}
		}

		// Token: 0x06014BEE RID: 84974 RVA: 0x0030337D File Offset: 0x0030157D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveRequest()
		{
		}

		// Token: 0x06014BEF RID: 84975 RVA: 0x00303385 File Offset: 0x00301585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveRequest(ReviveRequest other) : this()
		{
			this.useItem_ = other.useItem_;
			this.customParam_ = other.customParam_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014BF0 RID: 84976 RVA: 0x003033B6 File Offset: 0x003015B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveRequest Clone()
		{
			return new ReviveRequest(this);
		}

		// Token: 0x170044FD RID: 17661
		// (get) Token: 0x06014BF1 RID: 84977 RVA: 0x003033BE File Offset: 0x003015BE
		// (set) Token: 0x06014BF2 RID: 84978 RVA: 0x003033C6 File Offset: 0x003015C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool UseItem
		{
			get
			{
				return this.useItem_;
			}
			set
			{
				this.useItem_ = value;
			}
		}

		// Token: 0x170044FE RID: 17662
		// (get) Token: 0x06014BF3 RID: 84979 RVA: 0x003033CF File Offset: 0x003015CF
		// (set) Token: 0x06014BF4 RID: 84980 RVA: 0x003033D7 File Offset: 0x003015D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CustomParam
		{
			get
			{
				return this.customParam_;
			}
			set
			{
				this.customParam_ = value;
			}
		}

		// Token: 0x06014BF5 RID: 84981 RVA: 0x003033E0 File Offset: 0x003015E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReviveRequest);
		}

		// Token: 0x06014BF6 RID: 84982 RVA: 0x003033EE File Offset: 0x003015EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReviveRequest other)
		{
			return other != null && (other == this || (this.UseItem == other.UseItem && this.CustomParam == other.CustomParam && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014BF7 RID: 84983 RVA: 0x0030342C File Offset: 0x0030162C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.UseItem)
			{
				num ^= this.UseItem.GetHashCode();
			}
			if (this.CustomParam != 0)
			{
				num ^= this.CustomParam.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014BF8 RID: 84984 RVA: 0x00303484 File Offset: 0x00301684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014BF9 RID: 84985 RVA: 0x00303491 File Offset: 0x00301691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014BFA RID: 84986 RVA: 0x0030349C File Offset: 0x0030169C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CustomParam != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.CustomParam);
			}
			if (this.UseItem)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.UseItem);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014BFB RID: 84987 RVA: 0x003034F8 File Offset: 0x003016F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.UseItem)
			{
				num += 2;
			}
			if (this.CustomParam != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CustomParam);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014BFC RID: 84988 RVA: 0x00303544 File Offset: 0x00301744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReviveRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.UseItem)
			{
				this.UseItem = other.UseItem;
			}
			if (other.CustomParam != 0)
			{
				this.CustomParam = other.CustomParam;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014BFD RID: 84989 RVA: 0x00303594 File Offset: 0x00301794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014BFE RID: 84990 RVA: 0x003035A0 File Offset: 0x003017A0
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.UseItem = input.ReadBool();
					}
				}
				else
				{
					this.CustomParam = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007DB9 RID: 32185
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DBA RID: 32186
		public const int UseItemFieldNumber = 12;

		// Token: 0x04007DBB RID: 32187
		private bool useItem_;

		// Token: 0x04007DBC RID: 32188
		public const int CustomParamFieldNumber = 7;

		// Token: 0x04007DBD RID: 32189
		private int customParam_;
	}
}
