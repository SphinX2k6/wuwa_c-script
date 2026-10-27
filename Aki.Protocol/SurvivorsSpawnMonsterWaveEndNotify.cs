using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012E6 RID: 4838
	[NetMessage(EMessageId.SurvivorsSpawnMonsterWaveEndNotify)]
	public sealed class SurvivorsSpawnMonsterWaveEndNotify : IMessage<SurvivorsSpawnMonsterWaveEndNotify>, IMessage, IEquatable<SurvivorsSpawnMonsterWaveEndNotify>, IDeepCloneable<SurvivorsSpawnMonsterWaveEndNotify>, IBufferMessage
	{
		// Token: 0x06019BAC RID: 105388 RVA: 0x003BD4D9 File Offset: 0x003BB6D9
		[NullableContext(1)]
		public static SurvivorsSpawnMonsterWaveEndNotify Create()
		{
			return new SurvivorsSpawnMonsterWaveEndNotify();
		}

		// Token: 0x170056C9 RID: 22217
		// (get) Token: 0x06019BAD RID: 105389 RVA: 0x003BD4E0 File Offset: 0x003BB6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056CA RID: 22218
		// (get) Token: 0x06019BAE RID: 105390 RVA: 0x003BD4E3 File Offset: 0x003BB6E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsSpawnMonsterWaveEndNotify.Descriptor;
			}
		}

		// Token: 0x06019BAF RID: 105391 RVA: 0x003BD4EA File Offset: 0x003BB6EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsSpawnMonsterWaveEndNotify()
		{
		}

		// Token: 0x06019BB0 RID: 105392 RVA: 0x003BD4F2 File Offset: 0x003BB6F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsSpawnMonsterWaveEndNotify(SurvivorsSpawnMonsterWaveEndNotify other) : this()
		{
			this.countdownSecond_ = other.countdownSecond_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019BB1 RID: 105393 RVA: 0x003BD517 File Offset: 0x003BB717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsSpawnMonsterWaveEndNotify Clone()
		{
			return new SurvivorsSpawnMonsterWaveEndNotify(this);
		}

		// Token: 0x170056CB RID: 22219
		// (get) Token: 0x06019BB2 RID: 105394 RVA: 0x003BD51F File Offset: 0x003BB71F
		// (set) Token: 0x06019BB3 RID: 105395 RVA: 0x003BD527 File Offset: 0x003BB727
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

		// Token: 0x06019BB4 RID: 105396 RVA: 0x003BD530 File Offset: 0x003BB730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsSpawnMonsterWaveEndNotify);
		}

		// Token: 0x06019BB5 RID: 105397 RVA: 0x003BD53E File Offset: 0x003BB73E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsSpawnMonsterWaveEndNotify other)
		{
			return other != null && (other == this || (this.CountdownSecond == other.CountdownSecond && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019BB6 RID: 105398 RVA: 0x003BD56C File Offset: 0x003BB76C
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

		// Token: 0x06019BB7 RID: 105399 RVA: 0x003BD5AB File Offset: 0x003BB7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019BB8 RID: 105400 RVA: 0x003BD5B8 File Offset: 0x003BB7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019BB9 RID: 105401 RVA: 0x003BD5C1 File Offset: 0x003BB7C1
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

		// Token: 0x06019BBA RID: 105402 RVA: 0x003BD5F4 File Offset: 0x003BB7F4
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

		// Token: 0x06019BBB RID: 105403 RVA: 0x003BD632 File Offset: 0x003BB832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsSpawnMonsterWaveEndNotify other)
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

		// Token: 0x06019BBC RID: 105404 RVA: 0x003BD663 File Offset: 0x003BB863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019BBD RID: 105405 RVA: 0x003BD66C File Offset: 0x003BB86C
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

		// Token: 0x040096B5 RID: 38581
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096B6 RID: 38582
		public const int CountdownSecondFieldNumber = 11;

		// Token: 0x040096B7 RID: 38583
		private int countdownSecond_;
	}
}
