using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200125F RID: 4703
	[NetMessage(EMessageId.SimpleCombatEntityBuffUpdateNotify)]
	public sealed class SimpleCombatEntityBuffUpdateNotify : IMessage<SimpleCombatEntityBuffUpdateNotify>, IMessage, IEquatable<SimpleCombatEntityBuffUpdateNotify>, IDeepCloneable<SimpleCombatEntityBuffUpdateNotify>, IBufferMessage
	{
		// Token: 0x060191A9 RID: 102825 RVA: 0x003A8BB2 File Offset: 0x003A6DB2
		[NullableContext(1)]
		public static SimpleCombatEntityBuffUpdateNotify Create()
		{
			return new SimpleCombatEntityBuffUpdateNotify();
		}

		// Token: 0x170054D5 RID: 21717
		// (get) Token: 0x060191AA RID: 102826 RVA: 0x003A8BB9 File Offset: 0x003A6DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054D6 RID: 21718
		// (get) Token: 0x060191AB RID: 102827 RVA: 0x003A8BBC File Offset: 0x003A6DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatEntityBuffUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060191AC RID: 102828 RVA: 0x003A8BC3 File Offset: 0x003A6DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityBuffUpdateNotify()
		{
		}

		// Token: 0x060191AD RID: 102829 RVA: 0x003A8BCB File Offset: 0x003A6DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityBuffUpdateNotify(SimpleCombatEntityBuffUpdateNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isBuffAdd_ = other.isBuffAdd_;
			this.buffId_ = other.buffId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060191AE RID: 102830 RVA: 0x003A8C08 File Offset: 0x003A6E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityBuffUpdateNotify Clone()
		{
			return new SimpleCombatEntityBuffUpdateNotify(this);
		}

		// Token: 0x170054D7 RID: 21719
		// (get) Token: 0x060191AF RID: 102831 RVA: 0x003A8C10 File Offset: 0x003A6E10
		// (set) Token: 0x060191B0 RID: 102832 RVA: 0x003A8C18 File Offset: 0x003A6E18
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

		// Token: 0x170054D8 RID: 21720
		// (get) Token: 0x060191B1 RID: 102833 RVA: 0x003A8C21 File Offset: 0x003A6E21
		// (set) Token: 0x060191B2 RID: 102834 RVA: 0x003A8C29 File Offset: 0x003A6E29
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

		// Token: 0x170054D9 RID: 21721
		// (get) Token: 0x060191B3 RID: 102835 RVA: 0x003A8C32 File Offset: 0x003A6E32
		// (set) Token: 0x060191B4 RID: 102836 RVA: 0x003A8C3A File Offset: 0x003A6E3A
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

		// Token: 0x060191B5 RID: 102837 RVA: 0x003A8C43 File Offset: 0x003A6E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatEntityBuffUpdateNotify);
		}

		// Token: 0x060191B6 RID: 102838 RVA: 0x003A8C54 File Offset: 0x003A6E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatEntityBuffUpdateNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsBuffAdd == other.IsBuffAdd && this.BuffId == other.BuffId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060191B7 RID: 102839 RVA: 0x003A8CB0 File Offset: 0x003A6EB0
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

		// Token: 0x060191B8 RID: 102840 RVA: 0x003A8D21 File Offset: 0x003A6F21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060191B9 RID: 102841 RVA: 0x003A8D2E File Offset: 0x003A6F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060191BA RID: 102842 RVA: 0x003A8D38 File Offset: 0x003A6F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsBuffAdd)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsBuffAdd);
			}
			if (this.BuffId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.BuffId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060191BB RID: 102843 RVA: 0x003A8DB0 File Offset: 0x003A6FB0
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

		// Token: 0x060191BC RID: 102844 RVA: 0x003A8E14 File Offset: 0x003A7014
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

		// Token: 0x060191BD RID: 102845 RVA: 0x003A8E78 File Offset: 0x003A7078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060191BE RID: 102846 RVA: 0x003A8E84 File Offset: 0x003A7084
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
				if (num != 24U)
				{
					if (num != 88U)
					{
						if (num != 120U)
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

		// Token: 0x040094B3 RID: 38067
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094B4 RID: 38068
		public const int EntityIdFieldNumber = 15;

		// Token: 0x040094B5 RID: 38069
		private long entityId_;

		// Token: 0x040094B6 RID: 38070
		public const int IsBuffAddFieldNumber = 3;

		// Token: 0x040094B7 RID: 38071
		private bool isBuffAdd_;

		// Token: 0x040094B8 RID: 38072
		public const int BuffIdFieldNumber = 11;

		// Token: 0x040094B9 RID: 38073
		private int buffId_;
	}
}
