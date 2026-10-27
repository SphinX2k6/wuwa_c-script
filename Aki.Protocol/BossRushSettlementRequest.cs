using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001DF RID: 479
	[NetMessage(EMessageId.BossRushSettlementRequest)]
	public sealed class BossRushSettlementRequest : IMessage<BossRushSettlementRequest>, IMessage, IEquatable<BossRushSettlementRequest>, IDeepCloneable<BossRushSettlementRequest>, IBufferMessage
	{
		// Token: 0x06003613 RID: 13843 RVA: 0x00087FF2 File Offset: 0x000861F2
		[NullableContext(1)]
		public static BossRushSettlementRequest Create()
		{
			return new BossRushSettlementRequest();
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06003614 RID: 13844 RVA: 0x00087FF9 File Offset: 0x000861F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06003615 RID: 13845 RVA: 0x00087FFC File Offset: 0x000861FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushSettlementRequest.Descriptor;
			}
		}

		// Token: 0x06003616 RID: 13846 RVA: 0x00088003 File Offset: 0x00086203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushSettlementRequest()
		{
		}

		// Token: 0x06003617 RID: 13847 RVA: 0x0008800B File Offset: 0x0008620B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushSettlementRequest(BossRushSettlementRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003618 RID: 13848 RVA: 0x00088024 File Offset: 0x00086224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushSettlementRequest Clone()
		{
			return new BossRushSettlementRequest(this);
		}

		// Token: 0x06003619 RID: 13849 RVA: 0x0008802C File Offset: 0x0008622C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushSettlementRequest);
		}

		// Token: 0x0600361A RID: 13850 RVA: 0x0008803A File Offset: 0x0008623A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushSettlementRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600361B RID: 13851 RVA: 0x00088058 File Offset: 0x00086258
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

		// Token: 0x0600361C RID: 13852 RVA: 0x0008807E File Offset: 0x0008627E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600361D RID: 13853 RVA: 0x0008808B File Offset: 0x0008628B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600361E RID: 13854 RVA: 0x00088094 File Offset: 0x00086294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600361F RID: 13855 RVA: 0x000880AC File Offset: 0x000862AC
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

		// Token: 0x06003620 RID: 13856 RVA: 0x000880D2 File Offset: 0x000862D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushSettlementRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003621 RID: 13857 RVA: 0x000880EF File Offset: 0x000862EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003622 RID: 13858 RVA: 0x000880F8 File Offset: 0x000862F8
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

		// Token: 0x04002A91 RID: 10897
		private UnknownFieldSet _unknownFields;
	}
}
