using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001084 RID: 4228
	public sealed class RoleGood : IMessage<RoleGood>, IMessage, IEquatable<RoleGood>, IDeepCloneable<RoleGood>, IBufferMessage
	{
		// Token: 0x06016952 RID: 92498 RVA: 0x0034803E File Offset: 0x0034623E
		[NullableContext(1)]
		public static RoleGood Create()
		{
			return new RoleGood();
		}

		// Token: 0x17004B97 RID: 19351
		// (get) Token: 0x06016953 RID: 92499 RVA: 0x00348045 File Offset: 0x00346245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleGood> Parser
		{
			get
			{
				return RoleGood._parser;
			}
		}

		// Token: 0x17004B98 RID: 19352
		// (get) Token: 0x06016954 RID: 92500 RVA: 0x0034804C File Offset: 0x0034624C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B99 RID: 19353
		// (get) Token: 0x06016955 RID: 92501 RVA: 0x0034804F File Offset: 0x0034624F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleGood.Descriptor;
			}
		}

		// Token: 0x06016956 RID: 92502 RVA: 0x00348056 File Offset: 0x00346256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGood()
		{
		}

		// Token: 0x06016957 RID: 92503 RVA: 0x0034805E File Offset: 0x0034625E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGood(RoleGood other) : this()
		{
			this.roleId_ = other.roleId_;
			this.result_ = other.result_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016958 RID: 92504 RVA: 0x0034808F File Offset: 0x0034628F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGood Clone()
		{
			return new RoleGood(this);
		}

		// Token: 0x17004B9A RID: 19354
		// (get) Token: 0x06016959 RID: 92505 RVA: 0x00348097 File Offset: 0x00346297
		// (set) Token: 0x0601695A RID: 92506 RVA: 0x0034809F File Offset: 0x0034629F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17004B9B RID: 19355
		// (get) Token: 0x0601695B RID: 92507 RVA: 0x003480A8 File Offset: 0x003462A8
		// (set) Token: 0x0601695C RID: 92508 RVA: 0x003480B0 File Offset: 0x003462B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSettleResult Result
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

		// Token: 0x0601695D RID: 92509 RVA: 0x003480B9 File Offset: 0x003462B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleGood);
		}

		// Token: 0x0601695E RID: 92510 RVA: 0x003480C7 File Offset: 0x003462C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleGood other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Result == other.Result && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601695F RID: 92511 RVA: 0x00348108 File Offset: 0x00346308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Result != RoleSettleResult.Bad)
			{
				num ^= this.Result.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016960 RID: 92512 RVA: 0x00348166 File Offset: 0x00346366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016961 RID: 92513 RVA: 0x00348173 File Offset: 0x00346373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016962 RID: 92514 RVA: 0x0034817C File Offset: 0x0034637C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.Result != RoleSettleResult.Bad)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Result);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016963 RID: 92515 RVA: 0x003481D4 File Offset: 0x003463D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Result != RoleSettleResult.Bad)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Result);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016964 RID: 92516 RVA: 0x0034822C File Offset: 0x0034642C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleGood other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Result != RoleSettleResult.Bad)
			{
				this.Result = other.Result;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016965 RID: 92517 RVA: 0x0034827C File Offset: 0x0034647C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016966 RID: 92518 RVA: 0x00348288 File Offset: 0x00346488
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
						this.Result = (RoleSettleResult)input.ReadEnum();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040086E3 RID: 34531
		private static readonly MessageParser<RoleGood> _parser = new MessageParser<RoleGood>(() => new RoleGood());

		// Token: 0x040086E4 RID: 34532
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086E5 RID: 34533
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040086E6 RID: 34534
		private int roleId_;

		// Token: 0x040086E7 RID: 34535
		public const int ResultFieldNumber = 2;

		// Token: 0x040086E8 RID: 34536
		private RoleSettleResult result_;
	}
}
