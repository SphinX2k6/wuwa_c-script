using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000170 RID: 368
	[NetMessage(EMessageId.BattlePassRequest)]
	public sealed class BattlePassRequest : IMessage<BattlePassRequest>, IMessage, IEquatable<BattlePassRequest>, IDeepCloneable<BattlePassRequest>, IBufferMessage
	{
		// Token: 0x06002D50 RID: 11600 RVA: 0x00075539 File Offset: 0x00073739
		[NullableContext(1)]
		public static BattlePassRequest Create()
		{
			return new BattlePassRequest();
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06002D51 RID: 11601 RVA: 0x00075540 File Offset: 0x00073740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06002D52 RID: 11602 RVA: 0x00075543 File Offset: 0x00073743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassRequest.Descriptor;
			}
		}

		// Token: 0x06002D53 RID: 11603 RVA: 0x0007554A File Offset: 0x0007374A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassRequest()
		{
		}

		// Token: 0x06002D54 RID: 11604 RVA: 0x00075552 File Offset: 0x00073752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassRequest(BattlePassRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x0007556B File Offset: 0x0007376B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassRequest Clone()
		{
			return new BattlePassRequest(this);
		}

		// Token: 0x06002D56 RID: 11606 RVA: 0x00075573 File Offset: 0x00073773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassRequest);
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x00075581 File Offset: 0x00073781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06002D58 RID: 11608 RVA: 0x000755A0 File Offset: 0x000737A0
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

		// Token: 0x06002D59 RID: 11609 RVA: 0x000755C6 File Offset: 0x000737C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002D5A RID: 11610 RVA: 0x000755D3 File Offset: 0x000737D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x000755DC File Offset: 0x000737DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x000755F4 File Offset: 0x000737F4
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

		// Token: 0x06002D5D RID: 11613 RVA: 0x0007561A File Offset: 0x0007381A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x00075637 File Offset: 0x00073837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x00075640 File Offset: 0x00073840
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

		// Token: 0x0400282E RID: 10286
		private UnknownFieldSet _unknownFields;
	}
}
