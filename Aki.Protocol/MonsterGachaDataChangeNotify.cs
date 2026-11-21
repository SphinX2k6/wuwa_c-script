using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009ED RID: 2541
	[NetMessage(EMessageId.MonsterGachaDataChangeNotify)]
	public sealed class MonsterGachaDataChangeNotify : IMessage<MonsterGachaDataChangeNotify>, IMessage, IEquatable<MonsterGachaDataChangeNotify>, IDeepCloneable<MonsterGachaDataChangeNotify>, IBufferMessage
	{
		// Token: 0x0600DECC RID: 57036 RVA: 0x0020AEB5 File Offset: 0x002090B5
		[NullableContext(1)]
		public static MonsterGachaDataChangeNotify Create()
		{
			return new MonsterGachaDataChangeNotify();
		}

		// Token: 0x17002D24 RID: 11556
		// (get) Token: 0x0600DECD RID: 57037 RVA: 0x0020AEBC File Offset: 0x002090BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D25 RID: 11557
		// (get) Token: 0x0600DECE RID: 57038 RVA: 0x0020AEBF File Offset: 0x002090BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterGachaDataChangeNotify.Descriptor;
			}
		}

		// Token: 0x0600DECF RID: 57039 RVA: 0x0020AEC6 File Offset: 0x002090C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterGachaDataChangeNotify()
		{
		}

		// Token: 0x0600DED0 RID: 57040 RVA: 0x0020AECE File Offset: 0x002090CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterGachaDataChangeNotify(MonsterGachaDataChangeNotify other) : this()
		{
			this.monsterGachaDataPb_ = ((other.monsterGachaDataPb_ != null) ? other.monsterGachaDataPb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DED1 RID: 57041 RVA: 0x0020AF03 File Offset: 0x00209103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterGachaDataChangeNotify Clone()
		{
			return new MonsterGachaDataChangeNotify(this);
		}

		// Token: 0x17002D26 RID: 11558
		// (get) Token: 0x0600DED2 RID: 57042 RVA: 0x0020AF0B File Offset: 0x0020910B
		// (set) Token: 0x0600DED3 RID: 57043 RVA: 0x0020AF13 File Offset: 0x00209113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterGachaDataPb MonsterGachaDataPb
		{
			get
			{
				return this.monsterGachaDataPb_;
			}
			set
			{
				this.monsterGachaDataPb_ = value;
			}
		}

		// Token: 0x0600DED4 RID: 57044 RVA: 0x0020AF1C File Offset: 0x0020911C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterGachaDataChangeNotify);
		}

		// Token: 0x0600DED5 RID: 57045 RVA: 0x0020AF2A File Offset: 0x0020912A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterGachaDataChangeNotify other)
		{
			return other != null && (other == this || (object.Equals(this.MonsterGachaDataPb, other.MonsterGachaDataPb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DED6 RID: 57046 RVA: 0x0020AF60 File Offset: 0x00209160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.monsterGachaDataPb_ != null)
			{
				num ^= this.MonsterGachaDataPb.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DED7 RID: 57047 RVA: 0x0020AF9C File Offset: 0x0020919C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DED8 RID: 57048 RVA: 0x0020AFA9 File Offset: 0x002091A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DED9 RID: 57049 RVA: 0x0020AFB2 File Offset: 0x002091B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.monsterGachaDataPb_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.MonsterGachaDataPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DEDA RID: 57050 RVA: 0x0020AFE4 File Offset: 0x002091E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.monsterGachaDataPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MonsterGachaDataPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DEDB RID: 57051 RVA: 0x0020B024 File Offset: 0x00209224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterGachaDataChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.monsterGachaDataPb_ != null)
			{
				if (this.monsterGachaDataPb_ == null)
				{
					this.MonsterGachaDataPb = new MonsterGachaDataPb();
				}
				this.MonsterGachaDataPb.MergeFrom(other.MonsterGachaDataPb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DEDC RID: 57052 RVA: 0x0020B078 File Offset: 0x00209278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DEDD RID: 57053 RVA: 0x0020B084 File Offset: 0x00209284
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.monsterGachaDataPb_ == null)
					{
						this.MonsterGachaDataPb = new MonsterGachaDataPb();
					}
					input.ReadMessage(this.MonsterGachaDataPb);
				}
			}
		}

		// Token: 0x04005C45 RID: 23621
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C46 RID: 23622
		public const int MonsterGachaDataPbFieldNumber = 8;

		// Token: 0x04005C47 RID: 23623
		private MonsterGachaDataPb monsterGachaDataPb_;
	}
}
