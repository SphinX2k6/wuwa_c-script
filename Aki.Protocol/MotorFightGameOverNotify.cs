using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A41 RID: 2625
	[NetMessage(EMessageId.MotorFightGameOverNotify)]
	public sealed class MotorFightGameOverNotify : IMessage<MotorFightGameOverNotify>, IMessage, IEquatable<MotorFightGameOverNotify>, IDeepCloneable<MotorFightGameOverNotify>, IBufferMessage
	{
		// Token: 0x0600E52B RID: 58667 RVA: 0x00218049 File Offset: 0x00216249
		[NullableContext(1)]
		public static MotorFightGameOverNotify Create()
		{
			return new MotorFightGameOverNotify();
		}

		// Token: 0x17002E76 RID: 11894
		// (get) Token: 0x0600E52C RID: 58668 RVA: 0x00218050 File Offset: 0x00216250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E77 RID: 11895
		// (get) Token: 0x0600E52D RID: 58669 RVA: 0x00218053 File Offset: 0x00216253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightGameOverNotify.Descriptor;
			}
		}

		// Token: 0x0600E52E RID: 58670 RVA: 0x0021805A File Offset: 0x0021625A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightGameOverNotify()
		{
		}

		// Token: 0x0600E52F RID: 58671 RVA: 0x00218064 File Offset: 0x00216264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightGameOverNotify(MotorFightGameOverNotify other) : this()
		{
			this.win_ = other.win_;
			this.result_ = ((other.result_ != null) ? other.result_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E530 RID: 58672 RVA: 0x002180B0 File Offset: 0x002162B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightGameOverNotify Clone()
		{
			return new MotorFightGameOverNotify(this);
		}

		// Token: 0x17002E78 RID: 11896
		// (get) Token: 0x0600E531 RID: 58673 RVA: 0x002180B8 File Offset: 0x002162B8
		// (set) Token: 0x0600E532 RID: 58674 RVA: 0x002180C0 File Offset: 0x002162C0
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

		// Token: 0x17002E79 RID: 11897
		// (get) Token: 0x0600E533 RID: 58675 RVA: 0x002180C9 File Offset: 0x002162C9
		// (set) Token: 0x0600E534 RID: 58676 RVA: 0x002180D1 File Offset: 0x002162D1
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

		// Token: 0x0600E535 RID: 58677 RVA: 0x002180DA File Offset: 0x002162DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightGameOverNotify);
		}

		// Token: 0x0600E536 RID: 58678 RVA: 0x002180E8 File Offset: 0x002162E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightGameOverNotify other)
		{
			return other != null && (other == this || (this.Win == other.Win && object.Equals(this.Result, other.Result) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E537 RID: 58679 RVA: 0x00218138 File Offset: 0x00216338
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

		// Token: 0x0600E538 RID: 58680 RVA: 0x0021818D File Offset: 0x0021638D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E539 RID: 58681 RVA: 0x0021819A File Offset: 0x0021639A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E53A RID: 58682 RVA: 0x002181A4 File Offset: 0x002163A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.result_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Result);
			}
			if (this.Win)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.Win);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E53B RID: 58683 RVA: 0x00218200 File Offset: 0x00216400
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

		// Token: 0x0600E53C RID: 58684 RVA: 0x0021824C File Offset: 0x0021644C
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

		// Token: 0x0600E53D RID: 58685 RVA: 0x002182B4 File Offset: 0x002164B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E53E RID: 58686 RVA: 0x002182C0 File Offset: 0x002164C0
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
					if (num != 80U)
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

		// Token: 0x04005DAB RID: 23979
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DAC RID: 23980
		public const int WinFieldNumber = 10;

		// Token: 0x04005DAD RID: 23981
		private bool win_;

		// Token: 0x04005DAE RID: 23982
		public const int ResultFieldNumber = 3;

		// Token: 0x04005DAF RID: 23983
		private MotorFightResult result_;
	}
}
