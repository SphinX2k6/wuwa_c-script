using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200144E RID: 5198
	[NetMessage(EMessageId.TrapDefenseSpawnMonsterWaveEndNotify)]
	public sealed class TrapDefenseSpawnMonsterWaveEndNotify : IMessage<TrapDefenseSpawnMonsterWaveEndNotify>, IMessage, IEquatable<TrapDefenseSpawnMonsterWaveEndNotify>, IDeepCloneable<TrapDefenseSpawnMonsterWaveEndNotify>, IBufferMessage
	{
		// Token: 0x0601B87A RID: 112762 RVA: 0x003FC487 File Offset: 0x003FA687
		[NullableContext(1)]
		public static TrapDefenseSpawnMonsterWaveEndNotify Create()
		{
			return new TrapDefenseSpawnMonsterWaveEndNotify();
		}

		// Token: 0x17005CD5 RID: 23765
		// (get) Token: 0x0601B87B RID: 112763 RVA: 0x003FC48E File Offset: 0x003FA68E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CD6 RID: 23766
		// (get) Token: 0x0601B87C RID: 112764 RVA: 0x003FC491 File Offset: 0x003FA691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSpawnMonsterWaveEndNotify.Descriptor;
			}
		}

		// Token: 0x0601B87D RID: 112765 RVA: 0x003FC498 File Offset: 0x003FA698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpawnMonsterWaveEndNotify()
		{
		}

		// Token: 0x0601B87E RID: 112766 RVA: 0x003FC4A0 File Offset: 0x003FA6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpawnMonsterWaveEndNotify(TrapDefenseSpawnMonsterWaveEndNotify other) : this()
		{
			this.countdownSecond_ = other.countdownSecond_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B87F RID: 112767 RVA: 0x003FC4C5 File Offset: 0x003FA6C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpawnMonsterWaveEndNotify Clone()
		{
			return new TrapDefenseSpawnMonsterWaveEndNotify(this);
		}

		// Token: 0x17005CD7 RID: 23767
		// (get) Token: 0x0601B880 RID: 112768 RVA: 0x003FC4CD File Offset: 0x003FA6CD
		// (set) Token: 0x0601B881 RID: 112769 RVA: 0x003FC4D5 File Offset: 0x003FA6D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CountdownSecond
		{
			get
			{
				return this.countdownSecond_;
			}
			set
			{
				this.countdownSecond_ = value;
			}
		}

		// Token: 0x0601B882 RID: 112770 RVA: 0x003FC4DE File Offset: 0x003FA6DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSpawnMonsterWaveEndNotify);
		}

		// Token: 0x0601B883 RID: 112771 RVA: 0x003FC4EC File Offset: 0x003FA6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSpawnMonsterWaveEndNotify other)
		{
			return other != null && (other == this || (this.CountdownSecond == other.CountdownSecond && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B884 RID: 112772 RVA: 0x003FC51C File Offset: 0x003FA71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CountdownSecond != 0)
			{
				num ^= this.CountdownSecond.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B885 RID: 112773 RVA: 0x003FC55B File Offset: 0x003FA75B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B886 RID: 112774 RVA: 0x003FC568 File Offset: 0x003FA768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B887 RID: 112775 RVA: 0x003FC571 File Offset: 0x003FA771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CountdownSecond != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.CountdownSecond);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B888 RID: 112776 RVA: 0x003FC5A4 File Offset: 0x003FA7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CountdownSecond != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CountdownSecond);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B889 RID: 112777 RVA: 0x003FC5E2 File Offset: 0x003FA7E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseSpawnMonsterWaveEndNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CountdownSecond != 0)
			{
				this.CountdownSecond = other.CountdownSecond;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B88A RID: 112778 RVA: 0x003FC613 File Offset: 0x003FA813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B88B RID: 112779 RVA: 0x003FC61C File Offset: 0x003FA81C
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CountdownSecond = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009EC2 RID: 40642
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EC3 RID: 40643
		public const int CountdownSecondFieldNumber = 15;

		// Token: 0x04009EC4 RID: 40644
		private int countdownSecond_;
	}
}
