using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C35 RID: 3125
	public sealed class PhantomBattleBoardFighterInfoCtx : IMessage<PhantomBattleBoardFighterInfoCtx>, IMessage, IEquatable<PhantomBattleBoardFighterInfoCtx>, IDeepCloneable<PhantomBattleBoardFighterInfoCtx>, IBufferMessage
	{
		// Token: 0x06010F30 RID: 69424 RVA: 0x0027B385 File Offset: 0x00279585
		[NullableContext(1)]
		public static PhantomBattleBoardFighterInfoCtx Create()
		{
			return new PhantomBattleBoardFighterInfoCtx();
		}

		// Token: 0x170037F8 RID: 14328
		// (get) Token: 0x06010F31 RID: 69425 RVA: 0x0027B38C File Offset: 0x0027958C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037F9 RID: 14329
		// (get) Token: 0x06010F32 RID: 69426 RVA: 0x0027B38F File Offset: 0x0027958F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBoardFighterInfoCtx.Descriptor;
			}
		}

		// Token: 0x06010F33 RID: 69427 RVA: 0x0027B396 File Offset: 0x00279596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBoardFighterInfoCtx()
		{
		}

		// Token: 0x06010F34 RID: 69428 RVA: 0x0027B39E File Offset: 0x0027959E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBoardFighterInfoCtx(PhantomBattleBoardFighterInfoCtx other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010F35 RID: 69429 RVA: 0x0027B3B7 File Offset: 0x002795B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBoardFighterInfoCtx Clone()
		{
			return new PhantomBattleBoardFighterInfoCtx(this);
		}

		// Token: 0x06010F36 RID: 69430 RVA: 0x0027B3BF File Offset: 0x002795BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBoardFighterInfoCtx);
		}

		// Token: 0x06010F37 RID: 69431 RVA: 0x0027B3CD File Offset: 0x002795CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBoardFighterInfoCtx other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06010F38 RID: 69432 RVA: 0x0027B3EC File Offset: 0x002795EC
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

		// Token: 0x06010F39 RID: 69433 RVA: 0x0027B412 File Offset: 0x00279612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010F3A RID: 69434 RVA: 0x0027B41F File Offset: 0x0027961F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010F3B RID: 69435 RVA: 0x0027B428 File Offset: 0x00279628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010F3C RID: 69436 RVA: 0x0027B440 File Offset: 0x00279640
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

		// Token: 0x06010F3D RID: 69437 RVA: 0x0027B466 File Offset: 0x00279666
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

		// Token: 0x06010F3E RID: 69438 RVA: 0x0027B483 File Offset: 0x00279683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010F3F RID: 69439 RVA: 0x0027B48C File Offset: 0x0027968C
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

		// Token: 0x04006B78 RID: 27512
		private UnknownFieldSet _unknownFields;
	}
}
