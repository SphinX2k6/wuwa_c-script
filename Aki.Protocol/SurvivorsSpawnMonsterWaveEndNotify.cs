using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001355 RID: 4949
	[NetMessage(EMessageId.SurvivorsSpawnMonsterWaveEndNotify)]
	public sealed class SurvivorsSpawnMonsterWaveEndNotify : IMessage<SurvivorsSpawnMonsterWaveEndNotify>, IMessage, IEquatable<SurvivorsSpawnMonsterWaveEndNotify>, IDeepCloneable<SurvivorsSpawnMonsterWaveEndNotify>, IBufferMessage
	{
		// Token: 0x0601A5E2 RID: 108002 RVA: 0x003D7C09 File Offset: 0x003D5E09
		[NullableContext(1)]
		public static SurvivorsSpawnMonsterWaveEndNotify Create()
		{
			return new SurvivorsSpawnMonsterWaveEndNotify();
		}

		// Token: 0x1700594A RID: 22858
		// (get) Token: 0x0601A5E3 RID: 108003 RVA: 0x003D7C10 File Offset: 0x003D5E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700594B RID: 22859
		// (get) Token: 0x0601A5E4 RID: 108004 RVA: 0x003D7C13 File Offset: 0x003D5E13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsSpawnMonsterWaveEndNotify.Descriptor;
			}
		}

		// Token: 0x0601A5E5 RID: 108005 RVA: 0x003D7C1A File Offset: 0x003D5E1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsSpawnMonsterWaveEndNotify()
		{
		}

		// Token: 0x0601A5E6 RID: 108006 RVA: 0x003D7C22 File Offset: 0x003D5E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsSpawnMonsterWaveEndNotify(SurvivorsSpawnMonsterWaveEndNotify other) : this()
		{
			this.countdownSecond_ = other.countdownSecond_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A5E7 RID: 108007 RVA: 0x003D7C47 File Offset: 0x003D5E47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsSpawnMonsterWaveEndNotify Clone()
		{
			return new SurvivorsSpawnMonsterWaveEndNotify(this);
		}

		// Token: 0x1700594C RID: 22860
		// (get) Token: 0x0601A5E8 RID: 108008 RVA: 0x003D7C4F File Offset: 0x003D5E4F
		// (set) Token: 0x0601A5E9 RID: 108009 RVA: 0x003D7C57 File Offset: 0x003D5E57
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

		// Token: 0x0601A5EA RID: 108010 RVA: 0x003D7C60 File Offset: 0x003D5E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsSpawnMonsterWaveEndNotify);
		}

		// Token: 0x0601A5EB RID: 108011 RVA: 0x003D7C6E File Offset: 0x003D5E6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsSpawnMonsterWaveEndNotify other)
		{
			return other != null && (other == this || (this.CountdownSecond == other.CountdownSecond && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A5EC RID: 108012 RVA: 0x003D7C9C File Offset: 0x003D5E9C
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

		// Token: 0x0601A5ED RID: 108013 RVA: 0x003D7CDB File Offset: 0x003D5EDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A5EE RID: 108014 RVA: 0x003D7CE8 File Offset: 0x003D5EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A5EF RID: 108015 RVA: 0x003D7CF1 File Offset: 0x003D5EF1
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

		// Token: 0x0601A5F0 RID: 108016 RVA: 0x003D7D24 File Offset: 0x003D5F24
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

		// Token: 0x0601A5F1 RID: 108017 RVA: 0x003D7D62 File Offset: 0x003D5F62
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

		// Token: 0x0601A5F2 RID: 108018 RVA: 0x003D7D93 File Offset: 0x003D5F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A5F3 RID: 108019 RVA: 0x003D7D9C File Offset: 0x003D5F9C
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

		// Token: 0x04009ADF RID: 39647
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AE0 RID: 39648
		public const int CountdownSecondFieldNumber = 11;

		// Token: 0x04009AE1 RID: 39649
		private int countdownSecond_;
	}
}
