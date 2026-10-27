using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001225 RID: 4645
	[NetMessage(EMessageId.SimpleCombatEntityDieRequest)]
	public sealed class SimpleCombatEntityDieRequest : IMessage<SimpleCombatEntityDieRequest>, IMessage, IEquatable<SimpleCombatEntityDieRequest>, IDeepCloneable<SimpleCombatEntityDieRequest>, IBufferMessage
	{
		// Token: 0x06018C1F RID: 101407 RVA: 0x0039A6BA File Offset: 0x003988BA
		[NullableContext(1)]
		public static SimpleCombatEntityDieRequest Create()
		{
			return new SimpleCombatEntityDieRequest();
		}

		// Token: 0x17005374 RID: 21364
		// (get) Token: 0x06018C20 RID: 101408 RVA: 0x0039A6C1 File Offset: 0x003988C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005375 RID: 21365
		// (get) Token: 0x06018C21 RID: 101409 RVA: 0x0039A6C4 File Offset: 0x003988C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatEntityDieRequest.Descriptor;
			}
		}

		// Token: 0x06018C22 RID: 101410 RVA: 0x0039A6CB File Offset: 0x003988CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityDieRequest()
		{
		}

		// Token: 0x06018C23 RID: 101411 RVA: 0x0039A6DE File Offset: 0x003988DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityDieRequest(SimpleCombatEntityDieRequest other) : this()
		{
			this.entityDieCtxMap_ = other.entityDieCtxMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018C24 RID: 101412 RVA: 0x0039A708 File Offset: 0x00398908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityDieRequest Clone()
		{
			return new SimpleCombatEntityDieRequest(this);
		}

		// Token: 0x17005376 RID: 21366
		// (get) Token: 0x06018C25 RID: 101413 RVA: 0x0039A710 File Offset: 0x00398910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<long, SimpleCombatEntityDieContext> EntityDieCtxMap
		{
			get
			{
				return this.entityDieCtxMap_;
			}
		}

		// Token: 0x06018C26 RID: 101414 RVA: 0x0039A718 File Offset: 0x00398918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatEntityDieRequest);
		}

		// Token: 0x06018C27 RID: 101415 RVA: 0x0039A726 File Offset: 0x00398926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatEntityDieRequest other)
		{
			return other != null && (other == this || (this.EntityDieCtxMap.Equals(other.EntityDieCtxMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018C28 RID: 101416 RVA: 0x0039A75C File Offset: 0x0039895C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.EntityDieCtxMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018C29 RID: 101417 RVA: 0x0039A790 File Offset: 0x00398990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018C2A RID: 101418 RVA: 0x0039A79D File Offset: 0x0039899D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018C2B RID: 101419 RVA: 0x0039A7A6 File Offset: 0x003989A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityDieCtxMap_.WriteTo(ref output, SimpleCombatEntityDieRequest._map_entityDieCtxMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018C2C RID: 101420 RVA: 0x0039A7D0 File Offset: 0x003989D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityDieCtxMap_.CalculateSize(SimpleCombatEntityDieRequest._map_entityDieCtxMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018C2D RID: 101421 RVA: 0x0039A809 File Offset: 0x00398A09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleCombatEntityDieRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.entityDieCtxMap_.MergeFrom(other.entityDieCtxMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018C2E RID: 101422 RVA: 0x0039A837 File Offset: 0x00398A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018C2F RID: 101423 RVA: 0x0039A840 File Offset: 0x00398A40
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityDieCtxMap_.AddEntriesFrom(ref input, SimpleCombatEntityDieRequest._map_entityDieCtxMap_codec);
				}
			}
		}

		// Token: 0x04009221 RID: 37409
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009222 RID: 37410
		public const int EntityDieCtxMapFieldNumber = 7;

		// Token: 0x04009223 RID: 37411
		private static readonly MapField<long, SimpleCombatEntityDieContext>.Codec _map_entityDieCtxMap_codec = new MapField<long, SimpleCombatEntityDieContext>.Codec(FieldCodec.ForInt64(8U, 0L), FieldCodec.ForMessage<SimpleCombatEntityDieContext>(18U, SimpleCombatEntityDieContext.Parser), 58U);

		// Token: 0x04009224 RID: 37412
		private readonly MapField<long, SimpleCombatEntityDieContext> entityDieCtxMap_ = new MapField<long, SimpleCombatEntityDieContext>();
	}
}
