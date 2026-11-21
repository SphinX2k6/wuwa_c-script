using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200016C RID: 364
	[NetMessage(EMessageId.BattlePassEnterPush)]
	public sealed class BattlePassEnterPush : IMessage<BattlePassEnterPush>, IMessage, IEquatable<BattlePassEnterPush>, IDeepCloneable<BattlePassEnterPush>, IBufferMessage
	{
		// Token: 0x06002D43 RID: 11587 RVA: 0x00075A19 File Offset: 0x00073C19
		[NullableContext(1)]
		public static BattlePassEnterPush Create()
		{
			return new BattlePassEnterPush();
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06002D44 RID: 11588 RVA: 0x00075A20 File Offset: 0x00073C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06002D45 RID: 11589 RVA: 0x00075A23 File Offset: 0x00073C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassEnterPush.Descriptor;
			}
		}

		// Token: 0x06002D46 RID: 11590 RVA: 0x00075A2A File Offset: 0x00073C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassEnterPush()
		{
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x00075A32 File Offset: 0x00073C32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassEnterPush(BattlePassEnterPush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x00075A4B File Offset: 0x00073C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassEnterPush Clone()
		{
			return new BattlePassEnterPush(this);
		}

		// Token: 0x06002D49 RID: 11593 RVA: 0x00075A53 File Offset: 0x00073C53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassEnterPush);
		}

		// Token: 0x06002D4A RID: 11594 RVA: 0x00075A61 File Offset: 0x00073C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassEnterPush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x00075A80 File Offset: 0x00073C80
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

		// Token: 0x06002D4C RID: 11596 RVA: 0x00075AA6 File Offset: 0x00073CA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002D4D RID: 11597 RVA: 0x00075AB3 File Offset: 0x00073CB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D4E RID: 11598 RVA: 0x00075ABC File Offset: 0x00073CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D4F RID: 11599 RVA: 0x00075AD4 File Offset: 0x00073CD4
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

		// Token: 0x06002D50 RID: 11600 RVA: 0x00075AFA File Offset: 0x00073CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassEnterPush other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002D51 RID: 11601 RVA: 0x00075B17 File Offset: 0x00073D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D52 RID: 11602 RVA: 0x00075B20 File Offset: 0x00073D20
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

		// Token: 0x04002886 RID: 10374
		private UnknownFieldSet _unknownFields;
	}
}
