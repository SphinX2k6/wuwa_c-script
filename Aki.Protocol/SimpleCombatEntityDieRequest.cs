using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001261 RID: 4705
	[NetMessage(EMessageId.SimpleCombatEntityDieRequest)]
	public sealed class SimpleCombatEntityDieRequest : IMessage<SimpleCombatEntityDieRequest>, IMessage, IEquatable<SimpleCombatEntityDieRequest>, IDeepCloneable<SimpleCombatEntityDieRequest>, IBufferMessage
	{
		// Token: 0x060191F9 RID: 102905 RVA: 0x003AA562 File Offset: 0x003A8762
		[NullableContext(1)]
		public static SimpleCombatEntityDieRequest Create()
		{
			return new SimpleCombatEntityDieRequest();
		}

		// Token: 0x170054F1 RID: 21745
		// (get) Token: 0x060191FA RID: 102906 RVA: 0x003AA569 File Offset: 0x003A8769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054F2 RID: 21746
		// (get) Token: 0x060191FB RID: 102907 RVA: 0x003AA56C File Offset: 0x003A876C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatEntityDieRequest.Descriptor;
			}
		}

		// Token: 0x060191FC RID: 102908 RVA: 0x003AA573 File Offset: 0x003A8773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityDieRequest()
		{
		}

		// Token: 0x060191FD RID: 102909 RVA: 0x003AA586 File Offset: 0x003A8786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityDieRequest(SimpleCombatEntityDieRequest other) : this()
		{
			this.entityDieCtxMap_ = other.entityDieCtxMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060191FE RID: 102910 RVA: 0x003AA5B0 File Offset: 0x003A87B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityDieRequest Clone()
		{
			return new SimpleCombatEntityDieRequest(this);
		}

		// Token: 0x170054F3 RID: 21747
		// (get) Token: 0x060191FF RID: 102911 RVA: 0x003AA5B8 File Offset: 0x003A87B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<long, SimpleCombatEntityDieContext> EntityDieCtxMap
		{
			get
			{
				return this.entityDieCtxMap_;
			}
		}

		// Token: 0x06019200 RID: 102912 RVA: 0x003AA5C0 File Offset: 0x003A87C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatEntityDieRequest);
		}

		// Token: 0x06019201 RID: 102913 RVA: 0x003AA5CE File Offset: 0x003A87CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatEntityDieRequest other)
		{
			return other != null && (other == this || (this.EntityDieCtxMap.Equals(other.EntityDieCtxMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019202 RID: 102914 RVA: 0x003AA604 File Offset: 0x003A8804
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

		// Token: 0x06019203 RID: 102915 RVA: 0x003AA638 File Offset: 0x003A8838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019204 RID: 102916 RVA: 0x003AA645 File Offset: 0x003A8845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019205 RID: 102917 RVA: 0x003AA64E File Offset: 0x003A884E
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

		// Token: 0x06019206 RID: 102918 RVA: 0x003AA678 File Offset: 0x003A8878
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

		// Token: 0x06019207 RID: 102919 RVA: 0x003AA6B1 File Offset: 0x003A88B1
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

		// Token: 0x06019208 RID: 102920 RVA: 0x003AA6DF File Offset: 0x003A88DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019209 RID: 102921 RVA: 0x003AA6E8 File Offset: 0x003A88E8
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityDieCtxMap_.AddEntriesFrom(ref input, SimpleCombatEntityDieRequest._map_entityDieCtxMap_codec);
				}
			}
		}

		// Token: 0x040094D2 RID: 38098
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094D3 RID: 38099
		public const int EntityDieCtxMapFieldNumber = 13;

		// Token: 0x040094D4 RID: 38100
		private static readonly MapField<long, SimpleCombatEntityDieContext>.Codec _map_entityDieCtxMap_codec = new MapField<long, SimpleCombatEntityDieContext>.Codec(FieldCodec.ForInt64(8U, 0L), FieldCodec.ForMessage<SimpleCombatEntityDieContext>(18U, SimpleCombatEntityDieContext.Parser), 106U);

		// Token: 0x040094D5 RID: 38101
		private readonly MapField<long, SimpleCombatEntityDieContext> entityDieCtxMap_ = new MapField<long, SimpleCombatEntityDieContext>();
	}
}
