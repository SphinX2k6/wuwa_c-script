using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000700 RID: 1792
	[NetMessage(EMessageId.GmLevelActionRequest)]
	public sealed class GmLevelActionRequest : IMessage<GmLevelActionRequest>, IMessage, IEquatable<GmLevelActionRequest>, IDeepCloneable<GmLevelActionRequest>, IBufferMessage
	{
		// Token: 0x0600A326 RID: 41766 RVA: 0x0018A405 File Offset: 0x00188605
		[NullableContext(1)]
		public static GmLevelActionRequest Create()
		{
			return new GmLevelActionRequest();
		}

		// Token: 0x170020CB RID: 8395
		// (get) Token: 0x0600A327 RID: 41767 RVA: 0x0018A40C File Offset: 0x0018860C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020CC RID: 8396
		// (get) Token: 0x0600A328 RID: 41768 RVA: 0x0018A40F File Offset: 0x0018860F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GmLevelActionRequest.Descriptor;
			}
		}

		// Token: 0x0600A329 RID: 41769 RVA: 0x0018A416 File Offset: 0x00188616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmLevelActionRequest()
		{
		}

		// Token: 0x0600A32A RID: 41770 RVA: 0x0018A429 File Offset: 0x00188629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmLevelActionRequest(GmLevelActionRequest other) : this()
		{
			this.jsonStr_ = other.jsonStr_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A32B RID: 41771 RVA: 0x0018A44E File Offset: 0x0018864E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmLevelActionRequest Clone()
		{
			return new GmLevelActionRequest(this);
		}

		// Token: 0x170020CD RID: 8397
		// (get) Token: 0x0600A32C RID: 41772 RVA: 0x0018A456 File Offset: 0x00188656
		// (set) Token: 0x0600A32D RID: 41773 RVA: 0x0018A45E File Offset: 0x0018865E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string JsonStr
		{
			get
			{
				return this.jsonStr_;
			}
			set
			{
				this.jsonStr_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600A32E RID: 41774 RVA: 0x0018A471 File Offset: 0x00188671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GmLevelActionRequest);
		}

		// Token: 0x0600A32F RID: 41775 RVA: 0x0018A47F File Offset: 0x0018867F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GmLevelActionRequest other)
		{
			return other != null && (other == this || (!(this.JsonStr != other.JsonStr) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A330 RID: 41776 RVA: 0x0018A4B4 File Offset: 0x001886B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JsonStr.Length != 0)
			{
				num ^= this.JsonStr.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A331 RID: 41777 RVA: 0x0018A4F5 File Offset: 0x001886F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A332 RID: 41778 RVA: 0x0018A502 File Offset: 0x00188702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A333 RID: 41779 RVA: 0x0018A50B File Offset: 0x0018870B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JsonStr.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.JsonStr);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A334 RID: 41780 RVA: 0x0018A544 File Offset: 0x00188744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JsonStr.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.JsonStr);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A335 RID: 41781 RVA: 0x0018A587 File Offset: 0x00188787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GmLevelActionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JsonStr.Length != 0)
			{
				this.JsonStr = other.JsonStr;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A336 RID: 41782 RVA: 0x0018A5BD File Offset: 0x001887BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A337 RID: 41783 RVA: 0x0018A5C8 File Offset: 0x001887C8
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.JsonStr = input.ReadString();
				}
			}
		}

		// Token: 0x04004B76 RID: 19318
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B77 RID: 19319
		public const int JsonStrFieldNumber = 1;

		// Token: 0x04004B78 RID: 19320
		private string jsonStr_ = "";
	}
}
