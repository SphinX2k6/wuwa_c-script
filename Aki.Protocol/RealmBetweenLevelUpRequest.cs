using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E9E RID: 3742
	[NetMessage(EMessageId.RealmBetweenLevelUpRequest)]
	public sealed class RealmBetweenLevelUpRequest : IMessage<RealmBetweenLevelUpRequest>, IMessage, IEquatable<RealmBetweenLevelUpRequest>, IDeepCloneable<RealmBetweenLevelUpRequest>, IBufferMessage
	{
		// Token: 0x0601416F RID: 82287 RVA: 0x002ECB97 File Offset: 0x002EAD97
		[NullableContext(1)]
		public static RealmBetweenLevelUpRequest Create()
		{
			return new RealmBetweenLevelUpRequest();
		}

		// Token: 0x170042D5 RID: 17109
		// (get) Token: 0x06014170 RID: 82288 RVA: 0x002ECB9E File Offset: 0x002EAD9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042D6 RID: 17110
		// (get) Token: 0x06014171 RID: 82289 RVA: 0x002ECBA1 File Offset: 0x002EADA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RealmBetweenLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x06014172 RID: 82290 RVA: 0x002ECBA8 File Offset: 0x002EADA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenLevelUpRequest()
		{
		}

		// Token: 0x06014173 RID: 82291 RVA: 0x002ECBB0 File Offset: 0x002EADB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenLevelUpRequest(RealmBetweenLevelUpRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014174 RID: 82292 RVA: 0x002ECBC9 File Offset: 0x002EADC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenLevelUpRequest Clone()
		{
			return new RealmBetweenLevelUpRequest(this);
		}

		// Token: 0x06014175 RID: 82293 RVA: 0x002ECBD1 File Offset: 0x002EADD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RealmBetweenLevelUpRequest);
		}

		// Token: 0x06014176 RID: 82294 RVA: 0x002ECBDF File Offset: 0x002EADDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RealmBetweenLevelUpRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06014177 RID: 82295 RVA: 0x002ECC00 File Offset: 0x002EAE00
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

		// Token: 0x06014178 RID: 82296 RVA: 0x002ECC26 File Offset: 0x002EAE26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014179 RID: 82297 RVA: 0x002ECC33 File Offset: 0x002EAE33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601417A RID: 82298 RVA: 0x002ECC3C File Offset: 0x002EAE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601417B RID: 82299 RVA: 0x002ECC54 File Offset: 0x002EAE54
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

		// Token: 0x0601417C RID: 82300 RVA: 0x002ECC7A File Offset: 0x002EAE7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RealmBetweenLevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601417D RID: 82301 RVA: 0x002ECC97 File Offset: 0x002EAE97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601417E RID: 82302 RVA: 0x002ECCA0 File Offset: 0x002EAEA0
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

		// Token: 0x04007A7D RID: 31357
		private UnknownFieldSet _unknownFields;
	}
}
