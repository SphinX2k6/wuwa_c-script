using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AAE RID: 2734
	public sealed class MotorTechPb : IMessage<MotorTechPb>, IMessage, IEquatable<MotorTechPb>, IDeepCloneable<MotorTechPb>, IBufferMessage
	{
		// Token: 0x0600EDF3 RID: 60915 RVA: 0x0022BAA9 File Offset: 0x00229CA9
		[NullableContext(1)]
		public static MotorTechPb Create()
		{
			return new MotorTechPb();
		}

		// Token: 0x17003058 RID: 12376
		// (get) Token: 0x0600EDF4 RID: 60916 RVA: 0x0022BAB0 File Offset: 0x00229CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorTechPb> Parser
		{
			get
			{
				return MotorTechPb._parser;
			}
		}

		// Token: 0x17003059 RID: 12377
		// (get) Token: 0x0600EDF5 RID: 60917 RVA: 0x0022BAB7 File Offset: 0x00229CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700305A RID: 12378
		// (get) Token: 0x0600EDF6 RID: 60918 RVA: 0x0022BABA File Offset: 0x00229CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTechPb.Descriptor;
			}
		}

		// Token: 0x0600EDF7 RID: 60919 RVA: 0x0022BAC1 File Offset: 0x00229CC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechPb()
		{
		}

		// Token: 0x0600EDF8 RID: 60920 RVA: 0x0022BACC File Offset: 0x00229CCC
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

		// Token: 0x0600EDF9 RID: 60921 RVA: 0x0022BB2C File Offset: 0x00229D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechPb Clone()
		{
			return new MotorTechPb(this);
		}

		// Token: 0x1700305B RID: 12379
		// (get) Token: 0x0600EDFA RID: 60922 RVA: 0x0022BB34 File Offset: 0x00229D34
		// (set) Token: 0x0600EDFB RID: 60923 RVA: 0x0022BB3C File Offset: 0x00229D3C
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

		// Token: 0x1700305C RID: 12380
		// (get) Token: 0x0600EDFC RID: 60924 RVA: 0x0022BB45 File Offset: 0x00229D45
		// (set) Token: 0x0600EDFD RID: 60925 RVA: 0x0022BB4D File Offset: 0x00229D4D
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

		// Token: 0x1700305D RID: 12381
		// (get) Token: 0x0600EDFE RID: 60926 RVA: 0x0022BB56 File Offset: 0x00229D56
		// (set) Token: 0x0600EDFF RID: 60927 RVA: 0x0022BB5E File Offset: 0x00229D5E
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

		// Token: 0x1700305E RID: 12382
		// (get) Token: 0x0600EE00 RID: 60928 RVA: 0x0022BB67 File Offset: 0x00229D67
		// (set) Token: 0x0600EE01 RID: 60929 RVA: 0x0022BB6F File Offset: 0x00229D6F
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

		// Token: 0x1700305F RID: 12383
		// (get) Token: 0x0600EE02 RID: 60930 RVA: 0x0022BB78 File Offset: 0x00229D78
		// (set) Token: 0x0600EE03 RID: 60931 RVA: 0x0022BB80 File Offset: 0x00229D80
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

		// Token: 0x0600EE04 RID: 60932 RVA: 0x0022BB89 File Offset: 0x00229D89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTechPb);
		}

		// Token: 0x0600EE05 RID: 60933 RVA: 0x0022BB98 File Offset: 0x00229D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTechPb other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Level == other.Level && this.Unlock == other.Unlock && this.Current == other.Current && this.Target == other.Target && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EE06 RID: 60934 RVA: 0x0022BC14 File Offset: 0x00229E14
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

		// Token: 0x0600EE07 RID: 60935 RVA: 0x0022BCB7 File Offset: 0x00229EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EE08 RID: 60936 RVA: 0x0022BCC4 File Offset: 0x00229EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EE09 RID: 60937 RVA: 0x0022BCD0 File Offset: 0x00229ED0
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

		// Token: 0x0600EE0A RID: 60938 RVA: 0x0022BD7C File Offset: 0x00229F7C
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

		// Token: 0x0600EE0B RID: 60939 RVA: 0x0022BE10 File Offset: 0x0022A010
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

		// Token: 0x0600EE0C RID: 60940 RVA: 0x0022BE9C File Offset: 0x0022A09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EE0D RID: 60941 RVA: 0x0022BEA8 File Offset: 0x0022A0A8
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

		// Token: 0x04006050 RID: 24656
		private static readonly MessageParser<MotorTechPb> _parser = new MessageParser<MotorTechPb>(() => new MotorTechPb());

		// Token: 0x04006051 RID: 24657
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006052 RID: 24658
		public const int IdFieldNumber = 1;

		// Token: 0x04006053 RID: 24659
		private int id_;

		// Token: 0x04006054 RID: 24660
		public const int LevelFieldNumber = 2;

		// Token: 0x04006055 RID: 24661
		private int level_;

		// Token: 0x04006056 RID: 24662
		public const int UnlockFieldNumber = 3;

		// Token: 0x04006057 RID: 24663
		private bool unlock_;

		// Token: 0x04006058 RID: 24664
		public const int CurrentFieldNumber = 10;

		// Token: 0x04006059 RID: 24665
		private int current_;

		// Token: 0x0400605A RID: 24666
		public const int TargetFieldNumber = 11;

		// Token: 0x0400605B RID: 24667
		private int target_;
	}
}
