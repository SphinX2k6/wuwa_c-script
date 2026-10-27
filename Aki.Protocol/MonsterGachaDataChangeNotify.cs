using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009FE RID: 2558
	[NetMessage(EMessageId.MonsterGachaDataChangeNotify)]
	public sealed class MonsterGachaDataChangeNotify : IMessage<MonsterGachaDataChangeNotify>, IMessage, IEquatable<MonsterGachaDataChangeNotify>, IDeepCloneable<MonsterGachaDataChangeNotify>, IBufferMessage
	{
		// Token: 0x0600DFE6 RID: 57318 RVA: 0x0020D0A1 File Offset: 0x0020B2A1
		[NullableContext(1)]
		public static MonsterGachaDataChangeNotify Create()
		{
			return new MonsterGachaDataChangeNotify();
		}

		// Token: 0x17002D62 RID: 11618
		// (get) Token: 0x0600DFE7 RID: 57319 RVA: 0x0020D0A8 File Offset: 0x0020B2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D63 RID: 11619
		// (get) Token: 0x0600DFE8 RID: 57320 RVA: 0x0020D0AB File Offset: 0x0020B2AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterGachaDataChangeNotify.Descriptor;
			}
		}

		// Token: 0x0600DFE9 RID: 57321 RVA: 0x0020D0B2 File Offset: 0x0020B2B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterGachaDataChangeNotify()
		{
		}

		// Token: 0x0600DFEA RID: 57322 RVA: 0x0020D0BA File Offset: 0x0020B2BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterGachaDataChangeNotify(MonsterGachaDataChangeNotify other) : this()
		{
			this.monsterGachaDataPb_ = ((other.monsterGachaDataPb_ != null) ? other.monsterGachaDataPb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DFEB RID: 57323 RVA: 0x0020D0EF File Offset: 0x0020B2EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterGachaDataChangeNotify Clone()
		{
			return new MonsterGachaDataChangeNotify(this);
		}

		// Token: 0x17002D64 RID: 11620
		// (get) Token: 0x0600DFEC RID: 57324 RVA: 0x0020D0F7 File Offset: 0x0020B2F7
		// (set) Token: 0x0600DFED RID: 57325 RVA: 0x0020D0FF File Offset: 0x0020B2FF
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

		// Token: 0x0600DFEE RID: 57326 RVA: 0x0020D108 File Offset: 0x0020B308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterGachaDataChangeNotify);
		}

		// Token: 0x0600DFEF RID: 57327 RVA: 0x0020D116 File Offset: 0x0020B316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterGachaDataChangeNotify other)
		{
			return other != null && (other == this || (object.Equals(this.MonsterGachaDataPb, other.MonsterGachaDataPb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DFF0 RID: 57328 RVA: 0x0020D14C File Offset: 0x0020B34C
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

		// Token: 0x0600DFF1 RID: 57329 RVA: 0x0020D188 File Offset: 0x0020B388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DFF2 RID: 57330 RVA: 0x0020D195 File Offset: 0x0020B395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DFF3 RID: 57331 RVA: 0x0020D19E File Offset: 0x0020B39E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.monsterGachaDataPb_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.MonsterGachaDataPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DFF4 RID: 57332 RVA: 0x0020D1D0 File Offset: 0x0020B3D0
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

		// Token: 0x0600DFF5 RID: 57333 RVA: 0x0020D210 File Offset: 0x0020B410
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

		// Token: 0x0600DFF6 RID: 57334 RVA: 0x0020D264 File Offset: 0x0020B464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DFF7 RID: 57335 RVA: 0x0020D270 File Offset: 0x0020B470
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
				if (num != 26U)
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

		// Token: 0x04005C3C RID: 23612
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C3D RID: 23613
		public const int MonsterGachaDataPbFieldNumber = 3;

		// Token: 0x04005C3E RID: 23614
		private MonsterGachaDataPb monsterGachaDataPb_;
	}
}
