using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000169 RID: 361
	[NetMessage(EMessageId.BattlePassEnterPush)]
	public sealed class BattlePassEnterPush : IMessage<BattlePassEnterPush>, IMessage, IEquatable<BattlePassEnterPush>, IDeepCloneable<BattlePassEnterPush>, IBufferMessage
	{
		// Token: 0x06002CCC RID: 11468 RVA: 0x000745E5 File Offset: 0x000727E5
		[NullableContext(1)]
		public static BattlePassEnterPush Create()
		{
			return new BattlePassEnterPush();
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06002CCD RID: 11469 RVA: 0x000745EC File Offset: 0x000727EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06002CCE RID: 11470 RVA: 0x000745EF File Offset: 0x000727EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassEnterPush.Descriptor;
			}
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x000745F6 File Offset: 0x000727F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassEnterPush()
		{
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x000745FE File Offset: 0x000727FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassEnterPush(BattlePassEnterPush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x00074617 File Offset: 0x00072817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassEnterPush Clone()
		{
			return new BattlePassEnterPush(this);
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x0007461F File Offset: 0x0007281F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassEnterPush);
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x0007462D File Offset: 0x0007282D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassEnterPush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06002CD4 RID: 11476 RVA: 0x0007464C File Offset: 0x0007284C
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

		// Token: 0x06002CD5 RID: 11477 RVA: 0x00074672 File Offset: 0x00072872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x0007467F File Offset: 0x0007287F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x00074688 File Offset: 0x00072888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x000746A0 File Offset: 0x000728A0
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

		// Token: 0x06002CD9 RID: 11481 RVA: 0x000746C6 File Offset: 0x000728C6
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

		// Token: 0x06002CDA RID: 11482 RVA: 0x000746E3 File Offset: 0x000728E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x000746EC File Offset: 0x000728EC
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

		// Token: 0x04002812 RID: 10258
		private UnknownFieldSet _unknownFields;
	}
}
