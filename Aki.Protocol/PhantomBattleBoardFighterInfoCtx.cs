using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C25 RID: 3109
	public sealed class PhantomBattleBoardFighterInfoCtx : IMessage<PhantomBattleBoardFighterInfoCtx>, IMessage, IEquatable<PhantomBattleBoardFighterInfoCtx>, IDeepCloneable<PhantomBattleBoardFighterInfoCtx>, IBufferMessage
	{
		// Token: 0x06010E30 RID: 69168 RVA: 0x00279621 File Offset: 0x00277821
		[NullableContext(1)]
		public static PhantomBattleBoardFighterInfoCtx Create()
		{
			return new PhantomBattleBoardFighterInfoCtx();
		}

		// Token: 0x170037C1 RID: 14273
		// (get) Token: 0x06010E31 RID: 69169 RVA: 0x00279628 File Offset: 0x00277828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037C2 RID: 14274
		// (get) Token: 0x06010E32 RID: 69170 RVA: 0x0027962B File Offset: 0x0027782B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBoardFighterInfoCtx.Descriptor;
			}
		}

		// Token: 0x06010E33 RID: 69171 RVA: 0x00279632 File Offset: 0x00277832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBoardFighterInfoCtx()
		{
		}

		// Token: 0x06010E34 RID: 69172 RVA: 0x0027963A File Offset: 0x0027783A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBoardFighterInfoCtx(PhantomBattleBoardFighterInfoCtx other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010E35 RID: 69173 RVA: 0x00279653 File Offset: 0x00277853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBoardFighterInfoCtx Clone()
		{
			return new PhantomBattleBoardFighterInfoCtx(this);
		}

		// Token: 0x06010E36 RID: 69174 RVA: 0x0027965B File Offset: 0x0027785B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBoardFighterInfoCtx);
		}

		// Token: 0x06010E37 RID: 69175 RVA: 0x00279669 File Offset: 0x00277869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBoardFighterInfoCtx other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06010E38 RID: 69176 RVA: 0x00279688 File Offset: 0x00277888
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

		// Token: 0x06010E39 RID: 69177 RVA: 0x002796AE File Offset: 0x002778AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010E3A RID: 69178 RVA: 0x002796BB File Offset: 0x002778BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010E3B RID: 69179 RVA: 0x002796C4 File Offset: 0x002778C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010E3C RID: 69180 RVA: 0x002796DC File Offset: 0x002778DC
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

		// Token: 0x06010E3D RID: 69181 RVA: 0x00279702 File Offset: 0x00277902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBoardFighterInfoCtx other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010E3E RID: 69182 RVA: 0x0027971F File Offset: 0x0027791F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010E3F RID: 69183 RVA: 0x00279728 File Offset: 0x00277928
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

		// Token: 0x04006B8C RID: 27532
		private UnknownFieldSet _unknownFields;
	}
}
