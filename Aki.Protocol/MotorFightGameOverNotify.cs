using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A30 RID: 2608
	[NetMessage(EMessageId.MotorFightGameOverNotify)]
	public sealed class MotorFightGameOverNotify : IMessage<MotorFightGameOverNotify>, IMessage, IEquatable<MotorFightGameOverNotify>, IDeepCloneable<MotorFightGameOverNotify>, IBufferMessage
	{
		// Token: 0x0600E411 RID: 58385 RVA: 0x00215E59 File Offset: 0x00214059
		[NullableContext(1)]
		public static MotorFightGameOverNotify Create()
		{
			return new MotorFightGameOverNotify();
		}

		// Token: 0x17002E38 RID: 11832
		// (get) Token: 0x0600E412 RID: 58386 RVA: 0x00215E60 File Offset: 0x00214060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E39 RID: 11833
		// (get) Token: 0x0600E413 RID: 58387 RVA: 0x00215E63 File Offset: 0x00214063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightGameOverNotify.Descriptor;
			}
		}

		// Token: 0x0600E414 RID: 58388 RVA: 0x00215E6A File Offset: 0x0021406A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightGameOverNotify()
		{
		}

		// Token: 0x0600E415 RID: 58389 RVA: 0x00215E74 File Offset: 0x00214074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightGameOverNotify(MotorFightGameOverNotify other) : this()
		{
			this.win_ = other.win_;
			this.result_ = ((other.result_ != null) ? other.result_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E416 RID: 58390 RVA: 0x00215EC0 File Offset: 0x002140C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightGameOverNotify Clone()
		{
			return new MotorFightGameOverNotify(this);
		}

		// Token: 0x17002E3A RID: 11834
		// (get) Token: 0x0600E417 RID: 58391 RVA: 0x00215EC8 File Offset: 0x002140C8
		// (set) Token: 0x0600E418 RID: 58392 RVA: 0x00215ED0 File Offset: 0x002140D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Win
		{
			get
			{
				return this.win_;
			}
			set
			{
				this.win_ = value;
			}
		}

		// Token: 0x17002E3B RID: 11835
		// (get) Token: 0x0600E419 RID: 58393 RVA: 0x00215ED9 File Offset: 0x002140D9
		// (set) Token: 0x0600E41A RID: 58394 RVA: 0x00215EE1 File Offset: 0x002140E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightResult Result
		{
			get
			{
				return this.result_;
			}
			set
			{
				this.result_ = value;
			}
		}

		// Token: 0x0600E41B RID: 58395 RVA: 0x00215EEA File Offset: 0x002140EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightGameOverNotify);
		}

		// Token: 0x0600E41C RID: 58396 RVA: 0x00215EF8 File Offset: 0x002140F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightGameOverNotify other)
		{
			return other != null && (other == this || (this.Win == other.Win && object.Equals(this.Result, other.Result) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E41D RID: 58397 RVA: 0x00215F48 File Offset: 0x00214148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Win)
			{
				num ^= this.Win.GetHashCode();
			}
			if (this.result_ != null)
			{
				num ^= this.Result.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E41E RID: 58398 RVA: 0x00215F9D File Offset: 0x0021419D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E41F RID: 58399 RVA: 0x00215FAA File Offset: 0x002141AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E420 RID: 58400 RVA: 0x00215FB4 File Offset: 0x002141B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.result_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Result);
			}
			if (this.Win)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.Win);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E421 RID: 58401 RVA: 0x00216010 File Offset: 0x00214210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Win)
			{
				num += 2;
			}
			if (this.result_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Result);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E422 RID: 58402 RVA: 0x0021605C File Offset: 0x0021425C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightGameOverNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Win)
			{
				this.Win = other.Win;
			}
			if (other.result_ != null)
			{
				if (this.result_ == null)
				{
					this.Result = new MotorFightResult();
				}
				this.Result.MergeFrom(other.Result);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E423 RID: 58403 RVA: 0x002160C4 File Offset: 0x002142C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E424 RID: 58404 RVA: 0x002160D0 File Offset: 0x002142D0
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
				if (num != 18U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Win = input.ReadBool();
					}
				}
				else
				{
					if (this.result_ == null)
					{
						this.Result = new MotorFightResult();
					}
					input.ReadMessage(this.Result);
				}
			}
		}

		// Token: 0x04005DB4 RID: 23988
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DB5 RID: 23989
		public const int WinFieldNumber = 14;

		// Token: 0x04005DB6 RID: 23990
		private bool win_;

		// Token: 0x04005DB7 RID: 23991
		public const int ResultFieldNumber = 2;

		// Token: 0x04005DB8 RID: 23992
		private MotorFightResult result_;
	}
}
