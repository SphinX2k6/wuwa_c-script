using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000874 RID: 2164
	public sealed class JokerGuessRoundInfo : IMessage<JokerGuessRoundInfo>, IMessage, IEquatable<JokerGuessRoundInfo>, IDeepCloneable<JokerGuessRoundInfo>, IBufferMessage
	{
		// Token: 0x0600C0B7 RID: 49335 RVA: 0x001C9C7D File Offset: 0x001C7E7D
		[NullableContext(1)]
		public static JokerGuessRoundInfo Create()
		{
			return new JokerGuessRoundInfo();
		}

		// Token: 0x170026F0 RID: 9968
		// (get) Token: 0x0600C0B8 RID: 49336 RVA: 0x001C9C84 File Offset: 0x001C7E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026F1 RID: 9969
		// (get) Token: 0x0600C0B9 RID: 49337 RVA: 0x001C9C87 File Offset: 0x001C7E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessRoundInfo.Descriptor;
			}
		}

		// Token: 0x0600C0BA RID: 49338 RVA: 0x001C9C8E File Offset: 0x001C7E8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessRoundInfo()
		{
		}

		// Token: 0x0600C0BB RID: 49339 RVA: 0x001C9C96 File Offset: 0x001C7E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessRoundInfo(JokerGuessRoundInfo other) : this()
		{
			this.roundNum_ = other.roundNum_;
			this.changeResult_ = other.changeResult_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C0BC RID: 49340 RVA: 0x001C9CC7 File Offset: 0x001C7EC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessRoundInfo Clone()
		{
			return new JokerGuessRoundInfo(this);
		}

		// Token: 0x170026F2 RID: 9970
		// (get) Token: 0x0600C0BD RID: 49341 RVA: 0x001C9CCF File Offset: 0x001C7ECF
		// (set) Token: 0x0600C0BE RID: 49342 RVA: 0x001C9CD7 File Offset: 0x001C7ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundNum
		{
			get
			{
				return this.roundNum_;
			}
			set
			{
				this.roundNum_ = value;
			}
		}

		// Token: 0x170026F3 RID: 9971
		// (get) Token: 0x0600C0BF RID: 49343 RVA: 0x001C9CE0 File Offset: 0x001C7EE0
		// (set) Token: 0x0600C0C0 RID: 49344 RVA: 0x001C9CE8 File Offset: 0x001C7EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChangeResult
		{
			get
			{
				return this.changeResult_;
			}
			set
			{
				this.changeResult_ = value;
			}
		}

		// Token: 0x0600C0C1 RID: 49345 RVA: 0x001C9CF1 File Offset: 0x001C7EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessRoundInfo);
		}

		// Token: 0x0600C0C2 RID: 49346 RVA: 0x001C9CFF File Offset: 0x001C7EFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessRoundInfo other)
		{
			return other != null && (other == this || (this.RoundNum == other.RoundNum && this.ChangeResult == other.ChangeResult && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C0C3 RID: 49347 RVA: 0x001C9D40 File Offset: 0x001C7F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoundNum != 0)
			{
				num ^= this.RoundNum.GetHashCode();
			}
			if (this.ChangeResult != 0)
			{
				num ^= this.ChangeResult.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C0C4 RID: 49348 RVA: 0x001C9D98 File Offset: 0x001C7F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C0C5 RID: 49349 RVA: 0x001C9DA5 File Offset: 0x001C7FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C0C6 RID: 49350 RVA: 0x001C9DB0 File Offset: 0x001C7FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoundNum != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoundNum);
			}
			if (this.ChangeResult != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ChangeResult);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C0C7 RID: 49351 RVA: 0x001C9E08 File Offset: 0x001C8008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoundNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundNum);
			}
			if (this.ChangeResult != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChangeResult);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C0C8 RID: 49352 RVA: 0x001C9E60 File Offset: 0x001C8060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessRoundInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoundNum != 0)
			{
				this.RoundNum = other.RoundNum;
			}
			if (other.ChangeResult != 0)
			{
				this.ChangeResult = other.ChangeResult;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C0C9 RID: 49353 RVA: 0x001C9EB0 File Offset: 0x001C80B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C0CA RID: 49354 RVA: 0x001C9EBC File Offset: 0x001C80BC
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ChangeResult = input.ReadInt32();
					}
				}
				else
				{
					this.RoundNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x040053AD RID: 21421
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053AE RID: 21422
		public const int RoundNumFieldNumber = 1;

		// Token: 0x040053AF RID: 21423
		private int roundNum_;

		// Token: 0x040053B0 RID: 21424
		public const int ChangeResultFieldNumber = 2;

		// Token: 0x040053B1 RID: 21425
		private int changeResult_;
	}
}
