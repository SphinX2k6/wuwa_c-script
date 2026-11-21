using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CD0 RID: 3280
	[NetMessage(EMessageId.PhantomItemRequest)]
	public sealed class PhantomItemRequest : IMessage<PhantomItemRequest>, IMessage, IEquatable<PhantomItemRequest>, IDeepCloneable<PhantomItemRequest>, IBufferMessage
	{
		// Token: 0x06011C60 RID: 72800 RVA: 0x0029A445 File Offset: 0x00298645
		[NullableContext(1)]
		public static PhantomItemRequest Create()
		{
			return new PhantomItemRequest();
		}

		// Token: 0x17003AE6 RID: 15078
		// (get) Token: 0x06011C61 RID: 72801 RVA: 0x0029A44C File Offset: 0x0029864C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AE7 RID: 15079
		// (get) Token: 0x06011C62 RID: 72802 RVA: 0x0029A44F File Offset: 0x0029864F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomItemRequest.Descriptor;
			}
		}

		// Token: 0x06011C63 RID: 72803 RVA: 0x0029A456 File Offset: 0x00298656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemRequest()
		{
		}

		// Token: 0x06011C64 RID: 72804 RVA: 0x0029A45E File Offset: 0x0029865E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemRequest(PhantomItemRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011C65 RID: 72805 RVA: 0x0029A477 File Offset: 0x00298677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItemRequest Clone()
		{
			return new PhantomItemRequest(this);
		}

		// Token: 0x06011C66 RID: 72806 RVA: 0x0029A47F File Offset: 0x0029867F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomItemRequest);
		}

		// Token: 0x06011C67 RID: 72807 RVA: 0x0029A48D File Offset: 0x0029868D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomItemRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06011C68 RID: 72808 RVA: 0x0029A4AC File Offset: 0x002986AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011C69 RID: 72809 RVA: 0x0029A4D2 File Offset: 0x002986D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011C6A RID: 72810 RVA: 0x0029A4DF File Offset: 0x002986DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011C6B RID: 72811 RVA: 0x0029A4E8 File Offset: 0x002986E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011C6C RID: 72812 RVA: 0x0029A500 File Offset: 0x00298700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011C6D RID: 72813 RVA: 0x0029A526 File Offset: 0x00298726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011C6E RID: 72814 RVA: 0x0029A543 File Offset: 0x00298743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011C6F RID: 72815 RVA: 0x0029A54C File Offset: 0x0029874C
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007016 RID: 28694
		private UnknownFieldSet _unknownFields;
	}
}
