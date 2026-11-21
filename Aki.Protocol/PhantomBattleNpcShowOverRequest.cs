using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C8B RID: 3211
	[NetMessage(EMessageId.PhantomBattleNpcShowOverRequest)]
	public sealed class PhantomBattleNpcShowOverRequest : IMessage<PhantomBattleNpcShowOverRequest>, IMessage, IEquatable<PhantomBattleNpcShowOverRequest>, IDeepCloneable<PhantomBattleNpcShowOverRequest>, IBufferMessage
	{
		// Token: 0x060116D5 RID: 71381 RVA: 0x0028E33B File Offset: 0x0028C53B
		[NullableContext(1)]
		public static PhantomBattleNpcShowOverRequest Create()
		{
			return new PhantomBattleNpcShowOverRequest();
		}

		// Token: 0x170039B9 RID: 14777
		// (get) Token: 0x060116D6 RID: 71382 RVA: 0x0028E342 File Offset: 0x0028C542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039BA RID: 14778
		// (get) Token: 0x060116D7 RID: 71383 RVA: 0x0028E345 File Offset: 0x0028C545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleNpcShowOverRequest.Descriptor;
			}
		}

		// Token: 0x060116D8 RID: 71384 RVA: 0x0028E34C File Offset: 0x0028C54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleNpcShowOverRequest()
		{
		}

		// Token: 0x060116D9 RID: 71385 RVA: 0x0028E354 File Offset: 0x0028C554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleNpcShowOverRequest(PhantomBattleNpcShowOverRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060116DA RID: 71386 RVA: 0x0028E36D File Offset: 0x0028C56D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleNpcShowOverRequest Clone()
		{
			return new PhantomBattleNpcShowOverRequest(this);
		}

		// Token: 0x060116DB RID: 71387 RVA: 0x0028E375 File Offset: 0x0028C575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleNpcShowOverRequest);
		}

		// Token: 0x060116DC RID: 71388 RVA: 0x0028E383 File Offset: 0x0028C583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleNpcShowOverRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060116DD RID: 71389 RVA: 0x0028E3A4 File Offset: 0x0028C5A4
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

		// Token: 0x060116DE RID: 71390 RVA: 0x0028E3CA File Offset: 0x0028C5CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060116DF RID: 71391 RVA: 0x0028E3D7 File Offset: 0x0028C5D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060116E0 RID: 71392 RVA: 0x0028E3E0 File Offset: 0x0028C5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060116E1 RID: 71393 RVA: 0x0028E3F8 File Offset: 0x0028C5F8
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

		// Token: 0x060116E2 RID: 71394 RVA: 0x0028E41E File Offset: 0x0028C61E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleNpcShowOverRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060116E3 RID: 71395 RVA: 0x0028E43B File Offset: 0x0028C63B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060116E4 RID: 71396 RVA: 0x0028E444 File Offset: 0x0028C644
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

		// Token: 0x04006E6C RID: 28268
		private UnknownFieldSet _unknownFields;
	}
}
