using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000928 RID: 2344
	public sealed class LivingState : IMessage<LivingState>, IMessage, IEquatable<LivingState>, IDeepCloneable<LivingState>, IBufferMessage
	{
		// Token: 0x0600CEF8 RID: 52984 RVA: 0x001E7DEC File Offset: 0x001E5FEC
		[NullableContext(1)]
		public static LivingState Create()
		{
			return new LivingState();
		}

		// Token: 0x170029CB RID: 10699
		// (get) Token: 0x0600CEF9 RID: 52985 RVA: 0x001E7DF3 File Offset: 0x001E5FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LivingState> Parser
		{
			get
			{
				return LivingState._parser;
			}
		}

		// Token: 0x170029CC RID: 10700
		// (get) Token: 0x0600CEFA RID: 52986 RVA: 0x001E7DFA File Offset: 0x001E5FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029CD RID: 10701
		// (get) Token: 0x0600CEFB RID: 52987 RVA: 0x001E7DFD File Offset: 0x001E5FFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivingState.Descriptor;
			}
		}

		// Token: 0x0600CEFC RID: 52988 RVA: 0x001E7E04 File Offset: 0x001E6004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivingState()
		{
		}

		// Token: 0x0600CEFD RID: 52989 RVA: 0x001E7E0C File Offset: 0x001E600C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivingState(LivingState other) : this()
		{
			this.group_ = other.group_;
			this.livingStatus_ = other.livingStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CEFE RID: 52990 RVA: 0x001E7E3D File Offset: 0x001E603D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivingState Clone()
		{
			return new LivingState(this);
		}

		// Token: 0x170029CE RID: 10702
		// (get) Token: 0x0600CEFF RID: 52991 RVA: 0x001E7E45 File Offset: 0x001E6045
		// (set) Token: 0x0600CF00 RID: 52992 RVA: 0x001E7E4D File Offset: 0x001E604D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Group
		{
			get
			{
				return this.group_;
			}
			set
			{
				this.group_ = value;
			}
		}

		// Token: 0x170029CF RID: 10703
		// (get) Token: 0x0600CF01 RID: 52993 RVA: 0x001E7E56 File Offset: 0x001E6056
		// (set) Token: 0x0600CF02 RID: 52994 RVA: 0x001E7E5E File Offset: 0x001E605E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivingStatus LivingStatus
		{
			get
			{
				return this.livingStatus_;
			}
			set
			{
				this.livingStatus_ = value;
			}
		}

		// Token: 0x0600CF03 RID: 52995 RVA: 0x001E7E67 File Offset: 0x001E6067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivingState);
		}

		// Token: 0x0600CF04 RID: 52996 RVA: 0x001E7E75 File Offset: 0x001E6075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivingState other)
		{
			return other != null && (other == this || (this.Group == other.Group && this.LivingStatus == other.LivingStatus && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CF05 RID: 52997 RVA: 0x001E7EB4 File Offset: 0x001E60B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Group != 0)
			{
				num ^= this.Group.GetHashCode();
			}
			if (this.LivingStatus != LivingStatus.Alive)
			{
				num ^= this.LivingStatus.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CF06 RID: 52998 RVA: 0x001E7F12 File Offset: 0x001E6112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CF07 RID: 52999 RVA: 0x001E7F1F File Offset: 0x001E611F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF08 RID: 53000 RVA: 0x001E7F28 File Offset: 0x001E6128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Group != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Group);
			}
			if (this.LivingStatus != LivingStatus.Alive)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.LivingStatus);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CF09 RID: 53001 RVA: 0x001E7F80 File Offset: 0x001E6180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Group != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Group);
			}
			if (this.LivingStatus != LivingStatus.Alive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.LivingStatus);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CF0A RID: 53002 RVA: 0x001E7FD8 File Offset: 0x001E61D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LivingState other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Group != 0)
			{
				this.Group = other.Group;
			}
			if (other.LivingStatus != LivingStatus.Alive)
			{
				this.LivingStatus = other.LivingStatus;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CF0B RID: 53003 RVA: 0x001E8028 File Offset: 0x001E6228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CF0C RID: 53004 RVA: 0x001E8034 File Offset: 0x001E6234
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
						this.LivingStatus = (LivingStatus)input.ReadEnum();
					}
				}
				else
				{
					this.Group = input.ReadInt32();
				}
			}
		}

		// Token: 0x040057BB RID: 22459
		private static readonly MessageParser<LivingState> _parser = new MessageParser<LivingState>(() => new LivingState());

		// Token: 0x040057BC RID: 22460
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057BD RID: 22461
		public const int GroupFieldNumber = 1;

		// Token: 0x040057BE RID: 22462
		private int group_;

		// Token: 0x040057BF RID: 22463
		public const int LivingStatusFieldNumber = 2;

		// Token: 0x040057C0 RID: 22464
		private LivingStatus livingStatus_;
	}
}
