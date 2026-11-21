using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000046 RID: 70
	public sealed class AbyssRoleSelectInfo : IMessage<AbyssRoleSelectInfo>, IMessage, IEquatable<AbyssRoleSelectInfo>, IDeepCloneable<AbyssRoleSelectInfo>, IBufferMessage
	{
		// Token: 0x06001434 RID: 5172 RVA: 0x0003650D File Offset: 0x0003470D
		[NullableContext(1)]
		public static AbyssRoleSelectInfo Create()
		{
			return new AbyssRoleSelectInfo();
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x00036514 File Offset: 0x00034714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AbyssRoleSelectInfo> Parser
		{
			get
			{
				return AbyssRoleSelectInfo._parser;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x0003651B File Offset: 0x0003471B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x0003651E File Offset: 0x0003471E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssRoleSelectInfo.Descriptor;
			}
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00036525 File Offset: 0x00034725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleSelectInfo()
		{
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00036538 File Offset: 0x00034738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleSelectInfo(AbyssRoleSelectInfo other) : this()
		{
			this.playerId_ = other.playerId_;
			this.roleInfos_ = other.roleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x0003656E File Offset: 0x0003476E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleSelectInfo Clone()
		{
			return new AbyssRoleSelectInfo(this);
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x00036576 File Offset: 0x00034776
		// (set) Token: 0x0600143C RID: 5180 RVA: 0x0003657E File Offset: 0x0003477E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x00036587 File Offset: 0x00034787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssOneRoleSelectInfo> RoleInfos
		{
			get
			{
				return this.roleInfos_;
			}
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x0003658F File Offset: 0x0003478F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssRoleSelectInfo);
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x000365A0 File Offset: 0x000347A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssRoleSelectInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.roleInfos_.Equals(other.roleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x000365F0 File Offset: 0x000347F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			num ^= this.roleInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x0003663D File Offset: 0x0003483D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0003664A File Offset: 0x0003484A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x00036654 File Offset: 0x00034854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			this.roleInfos_.WriteTo(ref output, AbyssRoleSelectInfo._repeated_roleInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x000366A4 File Offset: 0x000348A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			num += this.roleInfos_.CalculateSize(AbyssRoleSelectInfo._repeated_roleInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x000366F8 File Offset: 0x000348F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssRoleSelectInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this.roleInfos_.Add(other.roleInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x00036745 File Offset: 0x00034945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x00036750 File Offset: 0x00034950
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.roleInfos_.AddEntriesFrom(ref input, AbyssRoleSelectInfo._repeated_roleInfos_codec);
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002092 RID: 8338
		private static readonly MessageParser<AbyssRoleSelectInfo> _parser = new MessageParser<AbyssRoleSelectInfo>(() => new AbyssRoleSelectInfo());

		// Token: 0x04002093 RID: 8339
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002094 RID: 8340
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04002095 RID: 8341
		private int playerId_;

		// Token: 0x04002096 RID: 8342
		public const int RoleInfosFieldNumber = 2;

		// Token: 0x04002097 RID: 8343
		private static readonly FieldCodec<AbyssOneRoleSelectInfo> _repeated_roleInfos_codec = FieldCodec.ForMessage<AbyssOneRoleSelectInfo>(18U, AbyssOneRoleSelectInfo.Parser);

		// Token: 0x04002098 RID: 8344
		private readonly RepeatedField<AbyssOneRoleSelectInfo> roleInfos_ = new RepeatedField<AbyssOneRoleSelectInfo>();
	}
}
