using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014C1 RID: 5313
	[NetMessage(EMessageId.TrapDefenseSpawnMonsterWaveEndNotify)]
	public sealed class TrapDefenseSpawnMonsterWaveEndNotify : IMessage<TrapDefenseSpawnMonsterWaveEndNotify>, IMessage, IEquatable<TrapDefenseSpawnMonsterWaveEndNotify>, IDeepCloneable<TrapDefenseSpawnMonsterWaveEndNotify>, IBufferMessage
	{
		// Token: 0x0601C305 RID: 115461 RVA: 0x0041775B File Offset: 0x0041595B
		[NullableContext(1)]
		public static TrapDefenseSpawnMonsterWaveEndNotify Create()
		{
			return new TrapDefenseSpawnMonsterWaveEndNotify();
		}

		// Token: 0x17005F6A RID: 24426
		// (get) Token: 0x0601C306 RID: 115462 RVA: 0x00417762 File Offset: 0x00415962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F6B RID: 24427
		// (get) Token: 0x0601C307 RID: 115463 RVA: 0x00417765 File Offset: 0x00415965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSpawnMonsterWaveEndNotify.Descriptor;
			}
		}

		// Token: 0x0601C308 RID: 115464 RVA: 0x0041776C File Offset: 0x0041596C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpawnMonsterWaveEndNotify()
		{
		}

		// Token: 0x0601C309 RID: 115465 RVA: 0x00417774 File Offset: 0x00415974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpawnMonsterWaveEndNotify(TrapDefenseSpawnMonsterWaveEndNotify other) : this()
		{
			this.countdownSecond_ = other.countdownSecond_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C30A RID: 115466 RVA: 0x00417799 File Offset: 0x00415999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpawnMonsterWaveEndNotify Clone()
		{
			return new TrapDefenseSpawnMonsterWaveEndNotify(this);
		}

		// Token: 0x17005F6C RID: 24428
		// (get) Token: 0x0601C30B RID: 115467 RVA: 0x004177A1 File Offset: 0x004159A1
		// (set) Token: 0x0601C30C RID: 115468 RVA: 0x004177A9 File Offset: 0x004159A9
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

		// Token: 0x0601C30D RID: 115469 RVA: 0x004177B2 File Offset: 0x004159B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSpawnMonsterWaveEndNotify);
		}

		// Token: 0x0601C30E RID: 115470 RVA: 0x004177C0 File Offset: 0x004159C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSpawnMonsterWaveEndNotify other)
		{
			return other != null && (other == this || (this.CountdownSecond == other.CountdownSecond && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C30F RID: 115471 RVA: 0x004177F0 File Offset: 0x004159F0
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

		// Token: 0x0601C310 RID: 115472 RVA: 0x0041782F File Offset: 0x00415A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C311 RID: 115473 RVA: 0x0041783C File Offset: 0x00415A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C312 RID: 115474 RVA: 0x00417845 File Offset: 0x00415A45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CountdownSecond != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.CountdownSecond);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C313 RID: 115475 RVA: 0x00417878 File Offset: 0x00415A78
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

		// Token: 0x0601C314 RID: 115476 RVA: 0x004178B6 File Offset: 0x00415AB6
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

		// Token: 0x0601C315 RID: 115477 RVA: 0x004178E7 File Offset: 0x00415AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C316 RID: 115478 RVA: 0x004178F0 File Offset: 0x00415AF0
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CountdownSecond = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A309 RID: 41737
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A30A RID: 41738
		public const int CountdownSecondFieldNumber = 11;

		// Token: 0x0400A30B RID: 41739
		private int countdownSecond_;
	}
}
