using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004AC RID: 1196
	public sealed class EntityStateProgress : IMessage<EntityStateProgress>, IMessage, IEquatable<EntityStateProgress>, IDeepCloneable<EntityStateProgress>, IBufferMessage
	{
		// Token: 0x0600725A RID: 29274 RVA: 0x00118F37 File Offset: 0x00117137
		[NullableContext(1)]
		public static EntityStateProgress Create()
		{
			return new EntityStateProgress();
		}

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x0600725B RID: 29275 RVA: 0x00118F3E File Offset: 0x0011713E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x0600725C RID: 29276 RVA: 0x00118F41 File Offset: 0x00117141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityStateProgress.Descriptor;
			}
		}

		// Token: 0x0600725D RID: 29277 RVA: 0x00118F48 File Offset: 0x00117148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStateProgress()
		{
		}

		// Token: 0x0600725E RID: 29278 RVA: 0x00118F5B File Offset: 0x0011715B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStateProgress(EntityStateProgress other) : this()
		{
			this.entityId_ = other.entityId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600725F RID: 29279 RVA: 0x00118F85 File Offset: 0x00117185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStateProgress Clone()
		{
			return new EntityStateProgress(this);
		}

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x06007260 RID: 29280 RVA: 0x00118F8D File Offset: 0x0011718D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EntityId
		{
			get
			{
				return this.entityId_;
			}
		}

		// Token: 0x06007261 RID: 29281 RVA: 0x00118F95 File Offset: 0x00117195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityStateProgress);
		}

		// Token: 0x06007262 RID: 29282 RVA: 0x00118FA3 File Offset: 0x001171A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityStateProgress other)
		{
			return other != null && (other == this || (this.entityId_.Equals(other.entityId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007263 RID: 29283 RVA: 0x00118FD8 File Offset: 0x001171D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entityId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007264 RID: 29284 RVA: 0x0011900C File Offset: 0x0011720C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007265 RID: 29285 RVA: 0x00119019 File Offset: 0x00117219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007266 RID: 29286 RVA: 0x00119022 File Offset: 0x00117222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityId_.WriteTo(ref output, EntityStateProgress._repeated_entityId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007267 RID: 29287 RVA: 0x0011904C File Offset: 0x0011724C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityId_.CalculateSize(EntityStateProgress._repeated_entityId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007268 RID: 29288 RVA: 0x00119085 File Offset: 0x00117285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityStateProgress other)
		{
			if (other == null)
			{
				return;
			}
			this.entityId_.Add(other.entityId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007269 RID: 29289 RVA: 0x001190B3 File Offset: 0x001172B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600726A RID: 29290 RVA: 0x001190BC File Offset: 0x001172BC
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityId_.AddEntriesFrom(ref input, EntityStateProgress._repeated_entityId_codec);
				}
			}
		}

		// Token: 0x04003D31 RID: 15665
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D32 RID: 15666
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003D33 RID: 15667
		private static readonly FieldCodec<int> _repeated_entityId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04003D34 RID: 15668
		private readonly RepeatedField<int> entityId_ = new RepeatedField<int>();
	}
}
