using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F2F RID: 3887
	[NetMessage(EMessageId.ReviveRequest)]
	public sealed class ReviveRequest : IMessage<ReviveRequest>, IMessage, IEquatable<ReviveRequest>, IDeepCloneable<ReviveRequest>, IBufferMessage
	{
		// Token: 0x06014CD0 RID: 85200 RVA: 0x00304A28 File Offset: 0x00302C28
		[NullableContext(1)]
		public static ReviveRequest Create()
		{
			return new ReviveRequest();
		}

		// Token: 0x17004525 RID: 17701
		// (get) Token: 0x06014CD1 RID: 85201 RVA: 0x00304A2F File Offset: 0x00302C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004526 RID: 17702
		// (get) Token: 0x06014CD2 RID: 85202 RVA: 0x00304A32 File Offset: 0x00302C32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReviveRequest.Descriptor;
			}
		}

		// Token: 0x06014CD3 RID: 85203 RVA: 0x00304A39 File Offset: 0x00302C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveRequest()
		{
		}

		// Token: 0x06014CD4 RID: 85204 RVA: 0x00304A41 File Offset: 0x00302C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveRequest(ReviveRequest other) : this()
		{
			this.useItem_ = other.useItem_;
			this.customParam_ = other.customParam_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014CD5 RID: 85205 RVA: 0x00304A72 File Offset: 0x00302C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveRequest Clone()
		{
			return new ReviveRequest(this);
		}

		// Token: 0x17004527 RID: 17703
		// (get) Token: 0x06014CD6 RID: 85206 RVA: 0x00304A7A File Offset: 0x00302C7A
		// (set) Token: 0x06014CD7 RID: 85207 RVA: 0x00304A82 File Offset: 0x00302C82
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

		// Token: 0x17004528 RID: 17704
		// (get) Token: 0x06014CD8 RID: 85208 RVA: 0x00304A8B File Offset: 0x00302C8B
		// (set) Token: 0x06014CD9 RID: 85209 RVA: 0x00304A93 File Offset: 0x00302C93
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

		// Token: 0x06014CDA RID: 85210 RVA: 0x00304A9C File Offset: 0x00302C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReviveRequest);
		}

		// Token: 0x06014CDB RID: 85211 RVA: 0x00304AAA File Offset: 0x00302CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReviveRequest other)
		{
			return other != null && (other == this || (this.UseItem == other.UseItem && this.CustomParam == other.CustomParam && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014CDC RID: 85212 RVA: 0x00304AE8 File Offset: 0x00302CE8
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

		// Token: 0x06014CDD RID: 85213 RVA: 0x00304B40 File Offset: 0x00302D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014CDE RID: 85214 RVA: 0x00304B4D File Offset: 0x00302D4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014CDF RID: 85215 RVA: 0x00304B58 File Offset: 0x00302D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UseItem)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.UseItem);
			}
			if (this.CustomParam != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.CustomParam);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014CE0 RID: 85216 RVA: 0x00304BB4 File Offset: 0x00302DB4
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

		// Token: 0x06014CE1 RID: 85217 RVA: 0x00304C00 File Offset: 0x00302E00
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

		// Token: 0x06014CE2 RID: 85218 RVA: 0x00304C50 File Offset: 0x00302E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014CE3 RID: 85219 RVA: 0x00304C5C File Offset: 0x00302E5C
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
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CustomParam = input.ReadInt32();
					}
				}
				else
				{
					this.UseItem = input.ReadBool();
				}
			}
		}

		// Token: 0x04007D8F RID: 32143
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D90 RID: 32144
		public const int UseItemFieldNumber = 7;

		// Token: 0x04007D91 RID: 32145
		private bool useItem_;

		// Token: 0x04007D92 RID: 32146
		public const int CustomParamFieldNumber = 10;

		// Token: 0x04007D93 RID: 32147
		private int customParam_;
	}
}
