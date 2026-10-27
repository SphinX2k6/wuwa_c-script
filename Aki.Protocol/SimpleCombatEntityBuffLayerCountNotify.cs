using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001222 RID: 4642
	[NetMessage(EMessageId.SimpleCombatEntityBuffLayerCountNotify)]
	public sealed class SimpleCombatEntityBuffLayerCountNotify : IMessage<SimpleCombatEntityBuffLayerCountNotify>, IMessage, IEquatable<SimpleCombatEntityBuffLayerCountNotify>, IDeepCloneable<SimpleCombatEntityBuffLayerCountNotify>, IBufferMessage
	{
		// Token: 0x06018BB9 RID: 101305 RVA: 0x003989C7 File Offset: 0x00396BC7
		[NullableContext(1)]
		public static SimpleCombatEntityBuffLayerCountNotify Create()
		{
			return new SimpleCombatEntityBuffLayerCountNotify();
		}

		// Token: 0x17005353 RID: 21331
		// (get) Token: 0x06018BBA RID: 101306 RVA: 0x003989CE File Offset: 0x00396BCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005354 RID: 21332
		// (get) Token: 0x06018BBB RID: 101307 RVA: 0x003989D1 File Offset: 0x00396BD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatEntityBuffLayerCountNotify.Descriptor;
			}
		}

		// Token: 0x06018BBC RID: 101308 RVA: 0x003989D8 File Offset: 0x00396BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityBuffLayerCountNotify()
		{
		}

		// Token: 0x06018BBD RID: 101309 RVA: 0x003989E0 File Offset: 0x00396BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityBuffLayerCountNotify(SimpleCombatEntityBuffLayerCountNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.layerCount_ = other.layerCount_;
			this.buffId_ = other.buffId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018BBE RID: 101310 RVA: 0x00398A1D File Offset: 0x00396C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityBuffLayerCountNotify Clone()
		{
			return new SimpleCombatEntityBuffLayerCountNotify(this);
		}

		// Token: 0x17005355 RID: 21333
		// (get) Token: 0x06018BBF RID: 101311 RVA: 0x00398A25 File Offset: 0x00396C25
		// (set) Token: 0x06018BC0 RID: 101312 RVA: 0x00398A2D File Offset: 0x00396C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17005356 RID: 21334
		// (get) Token: 0x06018BC1 RID: 101313 RVA: 0x00398A36 File Offset: 0x00396C36
		// (set) Token: 0x06018BC2 RID: 101314 RVA: 0x00398A3E File Offset: 0x00396C3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LayerCount
		{
			get
			{
				return this.layerCount_;
			}
			set
			{
				this.layerCount_ = value;
			}
		}

		// Token: 0x17005357 RID: 21335
		// (get) Token: 0x06018BC3 RID: 101315 RVA: 0x00398A47 File Offset: 0x00396C47
		// (set) Token: 0x06018BC4 RID: 101316 RVA: 0x00398A4F File Offset: 0x00396C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x06018BC5 RID: 101317 RVA: 0x00398A58 File Offset: 0x00396C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatEntityBuffLayerCountNotify);
		}

		// Token: 0x06018BC6 RID: 101318 RVA: 0x00398A68 File Offset: 0x00396C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatEntityBuffLayerCountNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.LayerCount == other.LayerCount && this.BuffId == other.BuffId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018BC7 RID: 101319 RVA: 0x00398AC4 File Offset: 0x00396CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.LayerCount != 0)
			{
				num ^= this.LayerCount.GetHashCode();
			}
			if (this.BuffId != 0)
			{
				num ^= this.BuffId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018BC8 RID: 101320 RVA: 0x00398B35 File Offset: 0x00396D35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018BC9 RID: 101321 RVA: 0x00398B42 File Offset: 0x00396D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018BCA RID: 101322 RVA: 0x00398B4C File Offset: 0x00396D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BuffId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			if (this.LayerCount != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.LayerCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018BCB RID: 101323 RVA: 0x00398BC4 File Offset: 0x00396DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.LayerCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LayerCount);
			}
			if (this.BuffId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018BCC RID: 101324 RVA: 0x00398C34 File Offset: 0x00396E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleCombatEntityBuffLayerCountNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.LayerCount != 0)
			{
				this.LayerCount = other.LayerCount;
			}
			if (other.BuffId != 0)
			{
				this.BuffId = other.BuffId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018BCD RID: 101325 RVA: 0x00398C98 File Offset: 0x00396E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018BCE RID: 101326 RVA: 0x00398CA4 File Offset: 0x00396EA4
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
				if (num != 16U)
				{
					if (num != 48U)
					{
						if (num != 56U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.LayerCount = input.ReadInt32();
						}
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.BuffId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040091FB RID: 37371
		private UnknownFieldSet _unknownFields;

		// Token: 0x040091FC RID: 37372
		public const int EntityIdFieldNumber = 6;

		// Token: 0x040091FD RID: 37373
		private long entityId_;

		// Token: 0x040091FE RID: 37374
		public const int LayerCountFieldNumber = 7;

		// Token: 0x040091FF RID: 37375
		private int layerCount_;

		// Token: 0x04009200 RID: 37376
		public const int BuffIdFieldNumber = 2;

		// Token: 0x04009201 RID: 37377
		private int buffId_;
	}
}
