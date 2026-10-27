using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CBD RID: 3261
	[NetMessage(EMessageId.PhantomBattleStartRequest)]
	public sealed class PhantomBattleStartRequest : IMessage<PhantomBattleStartRequest>, IMessage, IEquatable<PhantomBattleStartRequest>, IDeepCloneable<PhantomBattleStartRequest>, IBufferMessage
	{
		// Token: 0x06011A9F RID: 72351 RVA: 0x0029641B File Offset: 0x0029461B
		[NullableContext(1)]
		public static PhantomBattleStartRequest Create()
		{
			return new PhantomBattleStartRequest();
		}

		// Token: 0x17003A8A RID: 14986
		// (get) Token: 0x06011AA0 RID: 72352 RVA: 0x00296422 File Offset: 0x00294622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A8B RID: 14987
		// (get) Token: 0x06011AA1 RID: 72353 RVA: 0x00296425 File Offset: 0x00294625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleStartRequest.Descriptor;
			}
		}

		// Token: 0x06011AA2 RID: 72354 RVA: 0x0029642C File Offset: 0x0029462C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleStartRequest()
		{
		}

		// Token: 0x06011AA3 RID: 72355 RVA: 0x00296434 File Offset: 0x00294634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleStartRequest(PhantomBattleStartRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011AA4 RID: 72356 RVA: 0x0029644D File Offset: 0x0029464D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleStartRequest Clone()
		{
			return new PhantomBattleStartRequest(this);
		}

		// Token: 0x06011AA5 RID: 72357 RVA: 0x00296455 File Offset: 0x00294655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleStartRequest);
		}

		// Token: 0x06011AA6 RID: 72358 RVA: 0x00296463 File Offset: 0x00294663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleStartRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06011AA7 RID: 72359 RVA: 0x00296484 File Offset: 0x00294684
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

		// Token: 0x06011AA8 RID: 72360 RVA: 0x002964AA File Offset: 0x002946AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011AA9 RID: 72361 RVA: 0x002964B7 File Offset: 0x002946B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011AAA RID: 72362 RVA: 0x002964C0 File Offset: 0x002946C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011AAB RID: 72363 RVA: 0x002964D8 File Offset: 0x002946D8
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

		// Token: 0x06011AAC RID: 72364 RVA: 0x002964FE File Offset: 0x002946FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleStartRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011AAD RID: 72365 RVA: 0x0029651B File Offset: 0x0029471B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011AAE RID: 72366 RVA: 0x00296524 File Offset: 0x00294724
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

		// Token: 0x04006F35 RID: 28469
		private UnknownFieldSet _unknownFields;
	}
}
