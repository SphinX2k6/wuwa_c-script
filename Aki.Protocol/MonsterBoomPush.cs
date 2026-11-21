using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009E2 RID: 2530
	[NetMessage(EMessageId.MonsterBoomPush)]
	public sealed class MonsterBoomPush : IMessage<MonsterBoomPush>, IMessage, IEquatable<MonsterBoomPush>, IDeepCloneable<MonsterBoomPush>, IBufferMessage
	{
		// Token: 0x0600DDF6 RID: 56822 RVA: 0x002093E0 File Offset: 0x002075E0
		[NullableContext(1)]
		public static MonsterBoomPush Create()
		{
			return new MonsterBoomPush();
		}

		// Token: 0x17002CFA RID: 11514
		// (get) Token: 0x0600DDF7 RID: 56823 RVA: 0x002093E7 File Offset: 0x002075E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CFB RID: 11515
		// (get) Token: 0x0600DDF8 RID: 56824 RVA: 0x002093EA File Offset: 0x002075EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterBoomPush.Descriptor;
			}
		}

		// Token: 0x0600DDF9 RID: 56825 RVA: 0x002093F1 File Offset: 0x002075F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBoomPush()
		{
		}

		// Token: 0x0600DDFA RID: 56826 RVA: 0x002093F9 File Offset: 0x002075F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBoomPush(MonsterBoomPush other) : this()
		{
			this.delay_ = other.delay_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DDFB RID: 56827 RVA: 0x0020941E File Offset: 0x0020761E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBoomPush Clone()
		{
			return new MonsterBoomPush(this);
		}

		// Token: 0x17002CFC RID: 11516
		// (get) Token: 0x0600DDFC RID: 56828 RVA: 0x00209426 File Offset: 0x00207626
		// (set) Token: 0x0600DDFD RID: 56829 RVA: 0x0020942E File Offset: 0x0020762E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Delay
		{
			get
			{
				return this.delay_;
			}
			set
			{
				this.delay_ = value;
			}
		}

		// Token: 0x0600DDFE RID: 56830 RVA: 0x00209437 File Offset: 0x00207637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterBoomPush);
		}

		// Token: 0x0600DDFF RID: 56831 RVA: 0x00209445 File Offset: 0x00207645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterBoomPush other)
		{
			return other != null && (other == this || (this.Delay == other.Delay && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DE00 RID: 56832 RVA: 0x00209474 File Offset: 0x00207674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Delay != 0)
			{
				num ^= this.Delay.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DE01 RID: 56833 RVA: 0x002094B3 File Offset: 0x002076B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DE02 RID: 56834 RVA: 0x002094C0 File Offset: 0x002076C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE03 RID: 56835 RVA: 0x002094C9 File Offset: 0x002076C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Delay != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Delay);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DE04 RID: 56836 RVA: 0x002094FC File Offset: 0x002076FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Delay != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Delay);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DE05 RID: 56837 RVA: 0x0020953A File Offset: 0x0020773A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterBoomPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Delay != 0)
			{
				this.Delay = other.Delay;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DE06 RID: 56838 RVA: 0x0020956B File Offset: 0x0020776B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DE07 RID: 56839 RVA: 0x00209574 File Offset: 0x00207774
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Delay = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005C0E RID: 23566
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C0F RID: 23567
		public const int DelayFieldNumber = 13;

		// Token: 0x04005C10 RID: 23568
		private int delay_;
	}
}
