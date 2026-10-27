using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CCD RID: 3277
	[NetMessage(EMessageId.PhantomEquipGroupInfosRequest)]
	public sealed class PhantomEquipGroupInfosRequest : IMessage<PhantomEquipGroupInfosRequest>, IMessage, IEquatable<PhantomEquipGroupInfosRequest>, IDeepCloneable<PhantomEquipGroupInfosRequest>, IBufferMessage
	{
		// Token: 0x06011BD8 RID: 72664 RVA: 0x00298A95 File Offset: 0x00296C95
		[NullableContext(1)]
		public static PhantomEquipGroupInfosRequest Create()
		{
			return new PhantomEquipGroupInfosRequest();
		}

		// Token: 0x17003AC7 RID: 15047
		// (get) Token: 0x06011BD9 RID: 72665 RVA: 0x00298A9C File Offset: 0x00296C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AC8 RID: 15048
		// (get) Token: 0x06011BDA RID: 72666 RVA: 0x00298A9F File Offset: 0x00296C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomEquipGroupInfosRequest.Descriptor;
			}
		}

		// Token: 0x06011BDB RID: 72667 RVA: 0x00298AA6 File Offset: 0x00296CA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfosRequest()
		{
		}

		// Token: 0x06011BDC RID: 72668 RVA: 0x00298AAE File Offset: 0x00296CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfosRequest(PhantomEquipGroupInfosRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011BDD RID: 72669 RVA: 0x00298AC7 File Offset: 0x00296CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfosRequest Clone()
		{
			return new PhantomEquipGroupInfosRequest(this);
		}

		// Token: 0x06011BDE RID: 72670 RVA: 0x00298ACF File Offset: 0x00296CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomEquipGroupInfosRequest);
		}

		// Token: 0x06011BDF RID: 72671 RVA: 0x00298ADD File Offset: 0x00296CDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomEquipGroupInfosRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06011BE0 RID: 72672 RVA: 0x00298AFC File Offset: 0x00296CFC
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

		// Token: 0x06011BE1 RID: 72673 RVA: 0x00298B22 File Offset: 0x00296D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011BE2 RID: 72674 RVA: 0x00298B2F File Offset: 0x00296D2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011BE3 RID: 72675 RVA: 0x00298B38 File Offset: 0x00296D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011BE4 RID: 72676 RVA: 0x00298B50 File Offset: 0x00296D50
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

		// Token: 0x06011BE5 RID: 72677 RVA: 0x00298B76 File Offset: 0x00296D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomEquipGroupInfosRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011BE6 RID: 72678 RVA: 0x00298B93 File Offset: 0x00296D93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011BE7 RID: 72679 RVA: 0x00298B9C File Offset: 0x00296D9C
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

		// Token: 0x04006F81 RID: 28545
		private UnknownFieldSet _unknownFields;
	}
}
