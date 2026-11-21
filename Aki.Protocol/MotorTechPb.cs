using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A9D RID: 2717
	public sealed class MotorTechPb : IMessage<MotorTechPb>, IMessage, IEquatable<MotorTechPb>, IDeepCloneable<MotorTechPb>, IBufferMessage
	{
		// Token: 0x0600ECD9 RID: 60633 RVA: 0x002298AD File Offset: 0x00227AAD
		[NullableContext(1)]
		public static MotorTechPb Create()
		{
			return new MotorTechPb();
		}

		// Token: 0x1700301A RID: 12314
		// (get) Token: 0x0600ECDA RID: 60634 RVA: 0x002298B4 File Offset: 0x00227AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorTechPb> Parser
		{
			get
			{
				return MotorTechPb._parser;
			}
		}

		// Token: 0x1700301B RID: 12315
		// (get) Token: 0x0600ECDB RID: 60635 RVA: 0x002298BB File Offset: 0x00227ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700301C RID: 12316
		// (get) Token: 0x0600ECDC RID: 60636 RVA: 0x002298BE File Offset: 0x00227ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTechPb.Descriptor;
			}
		}

		// Token: 0x0600ECDD RID: 60637 RVA: 0x002298C5 File Offset: 0x00227AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechPb()
		{
		}

		// Token: 0x0600ECDE RID: 60638 RVA: 0x002298D0 File Offset: 0x00227AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechPb(MotorTechPb other) : this()
		{
			this.id_ = other.id_;
			this.level_ = other.level_;
			this.unlock_ = other.unlock_;
			this.current_ = other.current_;
			this.target_ = other.target_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ECDF RID: 60639 RVA: 0x00229930 File Offset: 0x00227B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechPb Clone()
		{
			return new MotorTechPb(this);
		}

		// Token: 0x1700301D RID: 12317
		// (get) Token: 0x0600ECE0 RID: 60640 RVA: 0x00229938 File Offset: 0x00227B38
		// (set) Token: 0x0600ECE1 RID: 60641 RVA: 0x00229940 File Offset: 0x00227B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700301E RID: 12318
		// (get) Token: 0x0600ECE2 RID: 60642 RVA: 0x00229949 File Offset: 0x00227B49
		// (set) Token: 0x0600ECE3 RID: 60643 RVA: 0x00229951 File Offset: 0x00227B51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x1700301F RID: 12319
		// (get) Token: 0x0600ECE4 RID: 60644 RVA: 0x0022995A File Offset: 0x00227B5A
		// (set) Token: 0x0600ECE5 RID: 60645 RVA: 0x00229962 File Offset: 0x00227B62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Unlock
		{
			get
			{
				return this.unlock_;
			}
			set
			{
				this.unlock_ = value;
			}
		}

		// Token: 0x17003020 RID: 12320
		// (get) Token: 0x0600ECE6 RID: 60646 RVA: 0x0022996B File Offset: 0x00227B6B
		// (set) Token: 0x0600ECE7 RID: 60647 RVA: 0x00229973 File Offset: 0x00227B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Current
		{
			get
			{
				return this.current_;
			}
			set
			{
				this.current_ = value;
			}
		}

		// Token: 0x17003021 RID: 12321
		// (get) Token: 0x0600ECE8 RID: 60648 RVA: 0x0022997C File Offset: 0x00227B7C
		// (set) Token: 0x0600ECE9 RID: 60649 RVA: 0x00229984 File Offset: 0x00227B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x0600ECEA RID: 60650 RVA: 0x0022998D File Offset: 0x00227B8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTechPb);
		}

		// Token: 0x0600ECEB RID: 60651 RVA: 0x0022999C File Offset: 0x00227B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTechPb other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Level == other.Level && this.Unlock == other.Unlock && this.Current == other.Current && this.Target == other.Target && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ECEC RID: 60652 RVA: 0x00229A18 File Offset: 0x00227C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Unlock)
			{
				num ^= this.Unlock.GetHashCode();
			}
			if (this.Current != 0)
			{
				int num2 = num;
				int num3 = this.Current;
				num = (num2 ^ num3.GetHashCode());
			}
			if (this.Target != 0)
			{
				num ^= this.Target.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ECED RID: 60653 RVA: 0x00229ABB File Offset: 0x00227CBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ECEE RID: 60654 RVA: 0x00229AC8 File Offset: 0x00227CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ECEF RID: 60655 RVA: 0x00229AD4 File Offset: 0x00227CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this.Unlock)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Unlock);
			}
			if (this.Current != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Current);
			}
			if (this.Target != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Target);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ECF0 RID: 60656 RVA: 0x00229B80 File Offset: 0x00227D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.Unlock)
			{
				num += 2;
			}
			if (this.Current != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Current);
			}
			if (this.Target != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Target);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ECF1 RID: 60657 RVA: 0x00229C14 File Offset: 0x00227E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorTechPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.Unlock)
			{
				this.Unlock = other.Unlock;
			}
			if (other.Current != 0)
			{
				this.Current = other.Current;
			}
			if (other.Target != 0)
			{
				this.Target = other.Target;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ECF2 RID: 60658 RVA: 0x00229CA0 File Offset: 0x00227EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ECF3 RID: 60659 RVA: 0x00229CAC File Offset: 0x00227EAC
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Unlock = input.ReadBool();
						continue;
					}
					if (num == 80U)
					{
						this.Current = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.Target = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006059 RID: 24665
		private static readonly MessageParser<MotorTechPb> _parser = new MessageParser<MotorTechPb>(() => new MotorTechPb());

		// Token: 0x0400605A RID: 24666
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400605B RID: 24667
		public const int IdFieldNumber = 1;

		// Token: 0x0400605C RID: 24668
		private int id_;

		// Token: 0x0400605D RID: 24669
		public const int LevelFieldNumber = 2;

		// Token: 0x0400605E RID: 24670
		private int level_;

		// Token: 0x0400605F RID: 24671
		public const int UnlockFieldNumber = 3;

		// Token: 0x04006060 RID: 24672
		private bool unlock_;

		// Token: 0x04006061 RID: 24673
		public const int CurrentFieldNumber = 10;

		// Token: 0x04006062 RID: 24674
		private int current_;

		// Token: 0x04006063 RID: 24675
		public const int TargetFieldNumber = 11;

		// Token: 0x04006064 RID: 24676
		private int target_;
	}
}
