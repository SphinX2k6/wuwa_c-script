using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200070A RID: 1802
	public sealed class GroupFormation : IMessage<GroupFormation>, IMessage, IEquatable<GroupFormation>, IDeepCloneable<GroupFormation>, IBufferMessage
	{
		// Token: 0x0600A445 RID: 42053 RVA: 0x0018CF9E File Offset: 0x0018B19E
		[NullableContext(1)]
		public static GroupFormation Create()
		{
			return new GroupFormation();
		}

		// Token: 0x17002108 RID: 8456
		// (get) Token: 0x0600A446 RID: 42054 RVA: 0x0018CFA5 File Offset: 0x0018B1A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GroupFormation> Parser
		{
			get
			{
				return GroupFormation._parser;
			}
		}

		// Token: 0x17002109 RID: 8457
		// (get) Token: 0x0600A447 RID: 42055 RVA: 0x0018CFAC File Offset: 0x0018B1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700210A RID: 8458
		// (get) Token: 0x0600A448 RID: 42056 RVA: 0x0018CFAF File Offset: 0x0018B1AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GroupFormation.Descriptor;
			}
		}

		// Token: 0x0600A449 RID: 42057 RVA: 0x0018CFB6 File Offset: 0x0018B1B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupFormation()
		{
		}

		// Token: 0x0600A44A RID: 42058 RVA: 0x0018CFC9 File Offset: 0x0018B1C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupFormation(GroupFormation other) : this()
		{
			this.levelGroup_ = other.levelGroup_;
			this.roleIds_ = other.roleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A44B RID: 42059 RVA: 0x0018CFFF File Offset: 0x0018B1FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupFormation Clone()
		{
			return new GroupFormation(this);
		}

		// Token: 0x1700210B RID: 8459
		// (get) Token: 0x0600A44C RID: 42060 RVA: 0x0018D007 File Offset: 0x0018B207
		// (set) Token: 0x0600A44D RID: 42061 RVA: 0x0018D00F File Offset: 0x0018B20F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelGroup
		{
			get
			{
				return this.levelGroup_;
			}
			set
			{
				this.levelGroup_ = value;
			}
		}

		// Token: 0x1700210C RID: 8460
		// (get) Token: 0x0600A44E RID: 42062 RVA: 0x0018D018 File Offset: 0x0018B218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x0600A44F RID: 42063 RVA: 0x0018D020 File Offset: 0x0018B220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GroupFormation);
		}

		// Token: 0x0600A450 RID: 42064 RVA: 0x0018D030 File Offset: 0x0018B230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GroupFormation other)
		{
			return other != null && (other == this || (this.LevelGroup == other.LevelGroup && this.roleIds_.Equals(other.roleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A451 RID: 42065 RVA: 0x0018D080 File Offset: 0x0018B280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelGroup != 0)
			{
				num ^= this.LevelGroup.GetHashCode();
			}
			num ^= this.roleIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A452 RID: 42066 RVA: 0x0018D0CD File Offset: 0x0018B2CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A453 RID: 42067 RVA: 0x0018D0DA File Offset: 0x0018B2DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A454 RID: 42068 RVA: 0x0018D0E4 File Offset: 0x0018B2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelGroup != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelGroup);
			}
			this.roleIds_.WriteTo(ref output, GroupFormation._repeated_roleIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A455 RID: 42069 RVA: 0x0018D134 File Offset: 0x0018B334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelGroup != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelGroup);
			}
			num += this.roleIds_.CalculateSize(GroupFormation._repeated_roleIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A456 RID: 42070 RVA: 0x0018D188 File Offset: 0x0018B388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GroupFormation other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelGroup != 0)
			{
				this.LevelGroup = other.LevelGroup;
			}
			this.roleIds_.Add(other.roleIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A457 RID: 42071 RVA: 0x0018D1D5 File Offset: 0x0018B3D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A458 RID: 42072 RVA: 0x0018D1E0 File Offset: 0x0018B3E0
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.roleIds_.AddEntriesFrom(ref input, GroupFormation._repeated_roleIds_codec);
					}
				}
				else
				{
					this.LevelGroup = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004C1B RID: 19483
		private static readonly MessageParser<GroupFormation> _parser = new MessageParser<GroupFormation>(() => new GroupFormation());

		// Token: 0x04004C1C RID: 19484
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C1D RID: 19485
		public const int LevelGroupFieldNumber = 1;

		// Token: 0x04004C1E RID: 19486
		private int levelGroup_;

		// Token: 0x04004C1F RID: 19487
		public const int RoleIdsFieldNumber = 2;

		// Token: 0x04004C20 RID: 19488
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04004C21 RID: 19489
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();
	}
}
