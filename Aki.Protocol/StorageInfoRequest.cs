using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001298 RID: 4760
	[NetMessage(EMessageId.StorageInfoRequest)]
	public sealed class StorageInfoRequest : IMessage<StorageInfoRequest>, IMessage, IEquatable<StorageInfoRequest>, IDeepCloneable<StorageInfoRequest>, IBufferMessage
	{
		// Token: 0x06019576 RID: 103798 RVA: 0x003AF3E1 File Offset: 0x003AD5E1
		[NullableContext(1)]
		public static StorageInfoRequest Create()
		{
			return new StorageInfoRequest();
		}

		// Token: 0x17005579 RID: 21881
		// (get) Token: 0x06019577 RID: 103799 RVA: 0x003AF3E8 File Offset: 0x003AD5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700557A RID: 21882
		// (get) Token: 0x06019578 RID: 103800 RVA: 0x003AF3EB File Offset: 0x003AD5EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StorageInfoRequest.Descriptor;
			}
		}

		// Token: 0x06019579 RID: 103801 RVA: 0x003AF3F2 File Offset: 0x003AD5F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoRequest()
		{
		}

		// Token: 0x0601957A RID: 103802 RVA: 0x003AF3FA File Offset: 0x003AD5FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoRequest(StorageInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601957B RID: 103803 RVA: 0x003AF413 File Offset: 0x003AD613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoRequest Clone()
		{
			return new StorageInfoRequest(this);
		}

		// Token: 0x0601957C RID: 103804 RVA: 0x003AF41B File Offset: 0x003AD61B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StorageInfoRequest);
		}

		// Token: 0x0601957D RID: 103805 RVA: 0x003AF429 File Offset: 0x003AD629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StorageInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601957E RID: 103806 RVA: 0x003AF448 File Offset: 0x003AD648
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

		// Token: 0x0601957F RID: 103807 RVA: 0x003AF46E File Offset: 0x003AD66E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019580 RID: 103808 RVA: 0x003AF47B File Offset: 0x003AD67B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019581 RID: 103809 RVA: 0x003AF484 File Offset: 0x003AD684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019582 RID: 103810 RVA: 0x003AF49C File Offset: 0x003AD69C
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

		// Token: 0x06019583 RID: 103811 RVA: 0x003AF4C2 File Offset: 0x003AD6C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StorageInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019584 RID: 103812 RVA: 0x003AF4DF File Offset: 0x003AD6DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019585 RID: 103813 RVA: 0x003AF4E8 File Offset: 0x003AD6E8
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

		// Token: 0x040094E8 RID: 38120
		private UnknownFieldSet _unknownFields;
	}
}
