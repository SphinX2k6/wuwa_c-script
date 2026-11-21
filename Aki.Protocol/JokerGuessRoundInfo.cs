using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000863 RID: 2147
	public sealed class JokerGuessRoundInfo : IMessage<JokerGuessRoundInfo>, IMessage, IEquatable<JokerGuessRoundInfo>, IDeepCloneable<JokerGuessRoundInfo>, IBufferMessage
	{
		// Token: 0x0600BF9B RID: 49051 RVA: 0x001C7995 File Offset: 0x001C5B95
		[NullableContext(1)]
		public static JokerGuessRoundInfo Create()
		{
			return new JokerGuessRoundInfo();
		}

		// Token: 0x170026B1 RID: 9905
		// (get) Token: 0x0600BF9C RID: 49052 RVA: 0x001C799C File Offset: 0x001C5B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026B2 RID: 9906
		// (get) Token: 0x0600BF9D RID: 49053 RVA: 0x001C799F File Offset: 0x001C5B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessRoundInfo.Descriptor;
			}
		}

		// Token: 0x0600BF9E RID: 49054 RVA: 0x001C79A6 File Offset: 0x001C5BA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessRoundInfo()
		{
		}

		// Token: 0x0600BF9F RID: 49055 RVA: 0x001C79AE File Offset: 0x001C5BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessRoundInfo(JokerGuessRoundInfo other) : this()
		{
			this.roundNum_ = other.roundNum_;
			this.changeResult_ = other.changeResult_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BFA0 RID: 49056 RVA: 0x001C79DF File Offset: 0x001C5BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessRoundInfo Clone()
		{
			return new JokerGuessRoundInfo(this);
		}

		// Token: 0x170026B3 RID: 9907
		// (get) Token: 0x0600BFA1 RID: 49057 RVA: 0x001C79E7 File Offset: 0x001C5BE7
		// (set) Token: 0x0600BFA2 RID: 49058 RVA: 0x001C79EF File Offset: 0x001C5BEF
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

		// Token: 0x170026B4 RID: 9908
		// (get) Token: 0x0600BFA3 RID: 49059 RVA: 0x001C79F8 File Offset: 0x001C5BF8
		// (set) Token: 0x0600BFA4 RID: 49060 RVA: 0x001C7A00 File Offset: 0x001C5C00
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

		// Token: 0x0600BFA5 RID: 49061 RVA: 0x001C7A09 File Offset: 0x001C5C09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessRoundInfo);
		}

		// Token: 0x0600BFA6 RID: 49062 RVA: 0x001C7A17 File Offset: 0x001C5C17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessRoundInfo other)
		{
			return other != null && (other == this || (this.RoundNum == other.RoundNum && this.ChangeResult == other.ChangeResult && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BFA7 RID: 49063 RVA: 0x001C7A58 File Offset: 0x001C5C58
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

		// Token: 0x0600BFA8 RID: 49064 RVA: 0x001C7AB0 File Offset: 0x001C5CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BFA9 RID: 49065 RVA: 0x001C7ABD File Offset: 0x001C5CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BFAA RID: 49066 RVA: 0x001C7AC8 File Offset: 0x001C5CC8
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

		// Token: 0x0600BFAB RID: 49067 RVA: 0x001C7B20 File Offset: 0x001C5D20
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

		// Token: 0x0600BFAC RID: 49068 RVA: 0x001C7B78 File Offset: 0x001C5D78
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

		// Token: 0x0600BFAD RID: 49069 RVA: 0x001C7BC8 File Offset: 0x001C5DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BFAE RID: 49070 RVA: 0x001C7BD4 File Offset: 0x001C5DD4
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

		// Token: 0x040053B4 RID: 21428
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053B5 RID: 21429
		public const int RoundNumFieldNumber = 1;

		// Token: 0x040053B6 RID: 21430
		private int roundNum_;

		// Token: 0x040053B7 RID: 21431
		public const int ChangeResultFieldNumber = 2;

		// Token: 0x040053B8 RID: 21432
		private int changeResult_;
	}
}
