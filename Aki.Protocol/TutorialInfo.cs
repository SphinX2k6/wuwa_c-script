using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001473 RID: 5235
	public sealed class TutorialInfo : IMessage<TutorialInfo>, IMessage, IEquatable<TutorialInfo>, IDeepCloneable<TutorialInfo>, IBufferMessage
	{
		// Token: 0x0601BB66 RID: 113510 RVA: 0x00402A40 File Offset: 0x00400C40
		[NullableContext(1)]
		public static TutorialInfo Create()
		{
			return new TutorialInfo();
		}

		// Token: 0x17005D73 RID: 23923
		// (get) Token: 0x0601BB67 RID: 113511 RVA: 0x00402A47 File Offset: 0x00400C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TutorialInfo> Parser
		{
			get
			{
				return TutorialInfo._parser;
			}
		}

		// Token: 0x17005D74 RID: 23924
		// (get) Token: 0x0601BB68 RID: 113512 RVA: 0x00402A4E File Offset: 0x00400C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D75 RID: 23925
		// (get) Token: 0x0601BB69 RID: 113513 RVA: 0x00402A51 File Offset: 0x00400C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TutorialInfo.Descriptor;
			}
		}

		// Token: 0x0601BB6A RID: 113514 RVA: 0x00402A58 File Offset: 0x00400C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialInfo()
		{
		}

		// Token: 0x0601BB6B RID: 113515 RVA: 0x00402A60 File Offset: 0x00400C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialInfo(TutorialInfo other) : this()
		{
			this.id_ = other.id_;
			this.createTime_ = other.createTime_;
			this.getAward_ = other.getAward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BB6C RID: 113516 RVA: 0x00402A9D File Offset: 0x00400C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialInfo Clone()
		{
			return new TutorialInfo(this);
		}

		// Token: 0x17005D76 RID: 23926
		// (get) Token: 0x0601BB6D RID: 113517 RVA: 0x00402AA5 File Offset: 0x00400CA5
		// (set) Token: 0x0601BB6E RID: 113518 RVA: 0x00402AAD File Offset: 0x00400CAD
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

		// Token: 0x17005D77 RID: 23927
		// (get) Token: 0x0601BB6F RID: 113519 RVA: 0x00402AB6 File Offset: 0x00400CB6
		// (set) Token: 0x0601BB70 RID: 113520 RVA: 0x00402ABE File Offset: 0x00400CBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CreateTime
		{
			get
			{
				return this.createTime_;
			}
			set
			{
				this.createTime_ = value;
			}
		}

		// Token: 0x17005D78 RID: 23928
		// (get) Token: 0x0601BB71 RID: 113521 RVA: 0x00402AC7 File Offset: 0x00400CC7
		// (set) Token: 0x0601BB72 RID: 113522 RVA: 0x00402ACF File Offset: 0x00400CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GetAward
		{
			get
			{
				return this.getAward_;
			}
			set
			{
				this.getAward_ = value;
			}
		}

		// Token: 0x0601BB73 RID: 113523 RVA: 0x00402AD8 File Offset: 0x00400CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TutorialInfo);
		}

		// Token: 0x0601BB74 RID: 113524 RVA: 0x00402AE8 File Offset: 0x00400CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TutorialInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.CreateTime == other.CreateTime && this.GetAward == other.GetAward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BB75 RID: 113525 RVA: 0x00402B44 File Offset: 0x00400D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.CreateTime != 0U)
			{
				num ^= this.CreateTime.GetHashCode();
			}
			if (this.GetAward)
			{
				num ^= this.GetAward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BB76 RID: 113526 RVA: 0x00402BB5 File Offset: 0x00400DB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BB77 RID: 113527 RVA: 0x00402BC2 File Offset: 0x00400DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BB78 RID: 113528 RVA: 0x00402BCC File Offset: 0x00400DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.CreateTime != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.CreateTime);
			}
			if (this.GetAward)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.GetAward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BB79 RID: 113529 RVA: 0x00402C40 File Offset: 0x00400E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.CreateTime != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CreateTime);
			}
			if (this.GetAward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BB7A RID: 113530 RVA: 0x00402CA4 File Offset: 0x00400EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TutorialInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.CreateTime != 0U)
			{
				this.CreateTime = other.CreateTime;
			}
			if (other.GetAward)
			{
				this.GetAward = other.GetAward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BB7B RID: 113531 RVA: 0x00402D08 File Offset: 0x00400F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BB7C RID: 113532 RVA: 0x00402D14 File Offset: 0x00400F14
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GetAward = input.ReadBool();
						}
					}
					else
					{
						this.CreateTime = input.ReadUInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009F9F RID: 40863
		private static readonly MessageParser<TutorialInfo> _parser = new MessageParser<TutorialInfo>(() => new TutorialInfo());

		// Token: 0x04009FA0 RID: 40864
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FA1 RID: 40865
		public const int IdFieldNumber = 1;

		// Token: 0x04009FA2 RID: 40866
		private int id_;

		// Token: 0x04009FA3 RID: 40867
		public const int CreateTimeFieldNumber = 2;

		// Token: 0x04009FA4 RID: 40868
		private uint createTime_;

		// Token: 0x04009FA5 RID: 40869
		public const int GetAwardFieldNumber = 3;

		// Token: 0x04009FA6 RID: 40870
		private bool getAward_;
	}
}
