using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009F3 RID: 2547
	[NetMessage(EMessageId.MonsterBoomPush)]
	public sealed class MonsterBoomPush : IMessage<MonsterBoomPush>, IMessage, IEquatable<MonsterBoomPush>, IDeepCloneable<MonsterBoomPush>, IBufferMessage
	{
		// Token: 0x0600DF10 RID: 57104 RVA: 0x0020B5CC File Offset: 0x002097CC
		[NullableContext(1)]
		public static MonsterBoomPush Create()
		{
			return new MonsterBoomPush();
		}

		// Token: 0x17002D38 RID: 11576
		// (get) Token: 0x0600DF11 RID: 57105 RVA: 0x0020B5D3 File Offset: 0x002097D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D39 RID: 11577
		// (get) Token: 0x0600DF12 RID: 57106 RVA: 0x0020B5D6 File Offset: 0x002097D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterBoomPush.Descriptor;
			}
		}

		// Token: 0x0600DF13 RID: 57107 RVA: 0x0020B5DD File Offset: 0x002097DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBoomPush()
		{
		}

		// Token: 0x0600DF14 RID: 57108 RVA: 0x0020B5E5 File Offset: 0x002097E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBoomPush(MonsterBoomPush other) : this()
		{
			this.delay_ = other.delay_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DF15 RID: 57109 RVA: 0x0020B60A File Offset: 0x0020980A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBoomPush Clone()
		{
			return new MonsterBoomPush(this);
		}

		// Token: 0x17002D3A RID: 11578
		// (get) Token: 0x0600DF16 RID: 57110 RVA: 0x0020B612 File Offset: 0x00209812
		// (set) Token: 0x0600DF17 RID: 57111 RVA: 0x0020B61A File Offset: 0x0020981A
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

		// Token: 0x0600DF18 RID: 57112 RVA: 0x0020B623 File Offset: 0x00209823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterBoomPush);
		}

		// Token: 0x0600DF19 RID: 57113 RVA: 0x0020B631 File Offset: 0x00209831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterBoomPush other)
		{
			return other != null && (other == this || (this.Delay == other.Delay && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DF1A RID: 57114 RVA: 0x0020B660 File Offset: 0x00209860
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

		// Token: 0x0600DF1B RID: 57115 RVA: 0x0020B69F File Offset: 0x0020989F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DF1C RID: 57116 RVA: 0x0020B6AC File Offset: 0x002098AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DF1D RID: 57117 RVA: 0x0020B6B5 File Offset: 0x002098B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Delay != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Delay);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DF1E RID: 57118 RVA: 0x0020B6E8 File Offset: 0x002098E8
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

		// Token: 0x0600DF1F RID: 57119 RVA: 0x0020B726 File Offset: 0x00209926
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

		// Token: 0x0600DF20 RID: 57120 RVA: 0x0020B757 File Offset: 0x00209957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DF21 RID: 57121 RVA: 0x0020B760 File Offset: 0x00209960
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Delay = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005C05 RID: 23557
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C06 RID: 23558
		public const int DelayFieldNumber = 14;

		// Token: 0x04005C07 RID: 23559
		private int delay_;
	}
}
