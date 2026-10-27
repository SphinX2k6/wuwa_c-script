using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011D9 RID: 4569
	[NetMessage(EMessageId.SetNpcPerformStateNotify)]
	public sealed class SetNpcPerformStateNotify : IMessage<SetNpcPerformStateNotify>, IMessage, IEquatable<SetNpcPerformStateNotify>, IDeepCloneable<SetNpcPerformStateNotify>, IBufferMessage
	{
		// Token: 0x060185C8 RID: 99784 RVA: 0x0038B111 File Offset: 0x00389311
		[NullableContext(1)]
		public static SetNpcPerformStateNotify Create()
		{
			return new SetNpcPerformStateNotify();
		}

		// Token: 0x17005205 RID: 20997
		// (get) Token: 0x060185C9 RID: 99785 RVA: 0x0038B118 File Offset: 0x00389318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005206 RID: 20998
		// (get) Token: 0x060185CA RID: 99786 RVA: 0x0038B11B File Offset: 0x0038931B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetNpcPerformStateNotify.Descriptor;
			}
		}

		// Token: 0x060185CB RID: 99787 RVA: 0x0038B122 File Offset: 0x00389322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetNpcPerformStateNotify()
		{
		}

		// Token: 0x060185CC RID: 99788 RVA: 0x0038B140 File Offset: 0x00389340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetNpcPerformStateNotify(SetNpcPerformStateNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.type_ = other.type_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060185CD RID: 99789 RVA: 0x0038B17D File Offset: 0x0038937D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetNpcPerformStateNotify Clone()
		{
			return new SetNpcPerformStateNotify(this);
		}

		// Token: 0x17005207 RID: 20999
		// (get) Token: 0x060185CE RID: 99790 RVA: 0x0038B185 File Offset: 0x00389385
		// (set) Token: 0x060185CF RID: 99791 RVA: 0x0038B18D File Offset: 0x0038938D
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

		// Token: 0x17005208 RID: 21000
		// (get) Token: 0x060185D0 RID: 99792 RVA: 0x0038B196 File Offset: 0x00389396
		// (set) Token: 0x060185D1 RID: 99793 RVA: 0x0038B19E File Offset: 0x0038939E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17005209 RID: 21001
		// (get) Token: 0x060185D2 RID: 99794 RVA: 0x0038B1B1 File Offset: 0x003893B1
		// (set) Token: 0x060185D3 RID: 99795 RVA: 0x0038B1B9 File Offset: 0x003893B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060185D4 RID: 99796 RVA: 0x0038B1CC File Offset: 0x003893CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetNpcPerformStateNotify);
		}

		// Token: 0x060185D5 RID: 99797 RVA: 0x0038B1DC File Offset: 0x003893DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetNpcPerformStateNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.Type != other.Type) && !(this.State != other.State) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060185D6 RID: 99798 RVA: 0x0038B240 File Offset: 0x00389440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Type.Length != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.State.Length != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060185D7 RID: 99799 RVA: 0x0038B2B5 File Offset: 0x003894B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060185D8 RID: 99800 RVA: 0x0038B2C2 File Offset: 0x003894C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060185D9 RID: 99801 RVA: 0x0038B2CC File Offset: 0x003894CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.State.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.State);
			}
			if (this.Type.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.Type);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060185DA RID: 99802 RVA: 0x0038B34C File Offset: 0x0038954C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Type.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Type);
			}
			if (this.State.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060185DB RID: 99803 RVA: 0x0038B3C4 File Offset: 0x003895C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetNpcPerformStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Type.Length != 0)
			{
				this.Type = other.Type;
			}
			if (other.State.Length != 0)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060185DC RID: 99804 RVA: 0x0038B432 File Offset: 0x00389632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060185DD RID: 99805 RVA: 0x0038B43C File Offset: 0x0038963C
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
				if (num != 58U)
				{
					if (num != 66U)
					{
						if (num != 104U)
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
						this.Type = input.ReadString();
					}
				}
				else
				{
					this.State = input.ReadString();
				}
			}
		}

		// Token: 0x04009021 RID: 36897
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009022 RID: 36898
		public const int EntityIdFieldNumber = 13;

		// Token: 0x04009023 RID: 36899
		private long entityId_;

		// Token: 0x04009024 RID: 36900
		public const int TypeFieldNumber = 8;

		// Token: 0x04009025 RID: 36901
		private string type_ = "";

		// Token: 0x04009026 RID: 36902
		public const int StateFieldNumber = 7;

		// Token: 0x04009027 RID: 36903
		private string state_ = "";
	}
}
