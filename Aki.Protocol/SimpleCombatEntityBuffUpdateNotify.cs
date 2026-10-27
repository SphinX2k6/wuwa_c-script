using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001223 RID: 4643
	[NetMessage(EMessageId.SimpleCombatEntityBuffUpdateNotify)]
	public sealed class SimpleCombatEntityBuffUpdateNotify : IMessage<SimpleCombatEntityBuffUpdateNotify>, IMessage, IEquatable<SimpleCombatEntityBuffUpdateNotify>, IDeepCloneable<SimpleCombatEntityBuffUpdateNotify>, IBufferMessage
	{
		// Token: 0x06018BCF RID: 101327 RVA: 0x00398D0F File Offset: 0x00396F0F
		[NullableContext(1)]
		public static SimpleCombatEntityBuffUpdateNotify Create()
		{
			return new SimpleCombatEntityBuffUpdateNotify();
		}

		// Token: 0x17005358 RID: 21336
		// (get) Token: 0x06018BD0 RID: 101328 RVA: 0x00398D16 File Offset: 0x00396F16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005359 RID: 21337
		// (get) Token: 0x06018BD1 RID: 101329 RVA: 0x00398D19 File Offset: 0x00396F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatEntityBuffUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06018BD2 RID: 101330 RVA: 0x00398D20 File Offset: 0x00396F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityBuffUpdateNotify()
		{
		}

		// Token: 0x06018BD3 RID: 101331 RVA: 0x00398D28 File Offset: 0x00396F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityBuffUpdateNotify(SimpleCombatEntityBuffUpdateNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isBuffAdd_ = other.isBuffAdd_;
			this.buffId_ = other.buffId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018BD4 RID: 101332 RVA: 0x00398D65 File Offset: 0x00396F65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityBuffUpdateNotify Clone()
		{
			return new SimpleCombatEntityBuffUpdateNotify(this);
		}

		// Token: 0x1700535A RID: 21338
		// (get) Token: 0x06018BD5 RID: 101333 RVA: 0x00398D6D File Offset: 0x00396F6D
		// (set) Token: 0x06018BD6 RID: 101334 RVA: 0x00398D75 File Offset: 0x00396F75
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

		// Token: 0x1700535B RID: 21339
		// (get) Token: 0x06018BD7 RID: 101335 RVA: 0x00398D7E File Offset: 0x00396F7E
		// (set) Token: 0x06018BD8 RID: 101336 RVA: 0x00398D86 File Offset: 0x00396F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsBuffAdd
		{
			get
			{
				return this.isBuffAdd_;
			}
			set
			{
				this.isBuffAdd_ = value;
			}
		}

		// Token: 0x1700535C RID: 21340
		// (get) Token: 0x06018BD9 RID: 101337 RVA: 0x00398D8F File Offset: 0x00396F8F
		// (set) Token: 0x06018BDA RID: 101338 RVA: 0x00398D97 File Offset: 0x00396F97
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

		// Token: 0x06018BDB RID: 101339 RVA: 0x00398DA0 File Offset: 0x00396FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatEntityBuffUpdateNotify);
		}

		// Token: 0x06018BDC RID: 101340 RVA: 0x00398DB0 File Offset: 0x00396FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatEntityBuffUpdateNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsBuffAdd == other.IsBuffAdd && this.BuffId == other.BuffId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018BDD RID: 101341 RVA: 0x00398E0C File Offset: 0x0039700C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsBuffAdd)
			{
				num ^= this.IsBuffAdd.GetHashCode();
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

		// Token: 0x06018BDE RID: 101342 RVA: 0x00398E7D File Offset: 0x0039707D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018BDF RID: 101343 RVA: 0x00398E8A File Offset: 0x0039708A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018BE0 RID: 101344 RVA: 0x00398E94 File Offset: 0x00397094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsBuffAdd)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsBuffAdd);
			}
			if (this.BuffId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BuffId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018BE1 RID: 101345 RVA: 0x00398F08 File Offset: 0x00397108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsBuffAdd)
			{
				num += 2;
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

		// Token: 0x06018BE2 RID: 101346 RVA: 0x00398F6C File Offset: 0x0039716C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleCombatEntityBuffUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsBuffAdd)
			{
				this.IsBuffAdd = other.IsBuffAdd;
			}
			if (other.BuffId != 0)
			{
				this.BuffId = other.BuffId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018BE3 RID: 101347 RVA: 0x00398FD0 File Offset: 0x003971D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018BE4 RID: 101348 RVA: 0x00398FDC File Offset: 0x003971DC
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
				if (num != 8U)
				{
					if (num != 24U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.IsBuffAdd = input.ReadBool();
				}
			}
		}

		// Token: 0x04009202 RID: 37378
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009203 RID: 37379
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04009204 RID: 37380
		private long entityId_;

		// Token: 0x04009205 RID: 37381
		public const int IsBuffAddFieldNumber = 1;

		// Token: 0x04009206 RID: 37382
		private bool isBuffAdd_;

		// Token: 0x04009207 RID: 37383
		public const int BuffIdFieldNumber = 3;

		// Token: 0x04009208 RID: 37384
		private int buffId_;
	}
}
