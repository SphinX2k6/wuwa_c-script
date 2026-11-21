using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CAD RID: 3245
	[NetMessage(EMessageId.PhantomBattleStartRequest)]
	public sealed class PhantomBattleStartRequest : IMessage<PhantomBattleStartRequest>, IMessage, IEquatable<PhantomBattleStartRequest>, IDeepCloneable<PhantomBattleStartRequest>, IBufferMessage
	{
		// Token: 0x0601199F RID: 72095 RVA: 0x002946BB File Offset: 0x002928BB
		[NullableContext(1)]
		public static PhantomBattleStartRequest Create()
		{
			return new PhantomBattleStartRequest();
		}

		// Token: 0x17003A53 RID: 14931
		// (get) Token: 0x060119A0 RID: 72096 RVA: 0x002946C2 File Offset: 0x002928C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A54 RID: 14932
		// (get) Token: 0x060119A1 RID: 72097 RVA: 0x002946C5 File Offset: 0x002928C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleStartRequest.Descriptor;
			}
		}

		// Token: 0x060119A2 RID: 72098 RVA: 0x002946CC File Offset: 0x002928CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleStartRequest()
		{
		}

		// Token: 0x060119A3 RID: 72099 RVA: 0x002946D4 File Offset: 0x002928D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleStartRequest(PhantomBattleStartRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060119A4 RID: 72100 RVA: 0x002946ED File Offset: 0x002928ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleStartRequest Clone()
		{
			return new PhantomBattleStartRequest(this);
		}

		// Token: 0x060119A5 RID: 72101 RVA: 0x002946F5 File Offset: 0x002928F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleStartRequest);
		}

		// Token: 0x060119A6 RID: 72102 RVA: 0x00294703 File Offset: 0x00292903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleStartRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060119A7 RID: 72103 RVA: 0x00294724 File Offset: 0x00292924
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

		// Token: 0x060119A8 RID: 72104 RVA: 0x0029474A File Offset: 0x0029294A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060119A9 RID: 72105 RVA: 0x00294757 File Offset: 0x00292957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060119AA RID: 72106 RVA: 0x00294760 File Offset: 0x00292960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060119AB RID: 72107 RVA: 0x00294778 File Offset: 0x00292978
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

		// Token: 0x060119AC RID: 72108 RVA: 0x0029479E File Offset: 0x0029299E
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

		// Token: 0x060119AD RID: 72109 RVA: 0x002947BB File Offset: 0x002929BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060119AE RID: 72110 RVA: 0x002947C4 File Offset: 0x002929C4
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

		// Token: 0x04006F49 RID: 28489
		private UnknownFieldSet _unknownFields;
	}
}
