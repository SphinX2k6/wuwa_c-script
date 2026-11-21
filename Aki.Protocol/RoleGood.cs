using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001074 RID: 4212
	public sealed class RoleGood : IMessage<RoleGood>, IMessage, IEquatable<RoleGood>, IDeepCloneable<RoleGood>, IBufferMessage
	{
		// Token: 0x0601686D RID: 92269 RVA: 0x00346966 File Offset: 0x00344B66
		[NullableContext(1)]
		public static RoleGood Create()
		{
			return new RoleGood();
		}

		// Token: 0x17004B6D RID: 19309
		// (get) Token: 0x0601686E RID: 92270 RVA: 0x0034696D File Offset: 0x00344B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleGood> Parser
		{
			get
			{
				return RoleGood._parser;
			}
		}

		// Token: 0x17004B6E RID: 19310
		// (get) Token: 0x0601686F RID: 92271 RVA: 0x00346974 File Offset: 0x00344B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B6F RID: 19311
		// (get) Token: 0x06016870 RID: 92272 RVA: 0x00346977 File Offset: 0x00344B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleGood.Descriptor;
			}
		}

		// Token: 0x06016871 RID: 92273 RVA: 0x0034697E File Offset: 0x00344B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGood()
		{
		}

		// Token: 0x06016872 RID: 92274 RVA: 0x00346986 File Offset: 0x00344B86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGood(RoleGood other) : this()
		{
			this.roleId_ = other.roleId_;
			this.result_ = other.result_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016873 RID: 92275 RVA: 0x003469B7 File Offset: 0x00344BB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGood Clone()
		{
			return new RoleGood(this);
		}

		// Token: 0x17004B70 RID: 19312
		// (get) Token: 0x06016874 RID: 92276 RVA: 0x003469BF File Offset: 0x00344BBF
		// (set) Token: 0x06016875 RID: 92277 RVA: 0x003469C7 File Offset: 0x00344BC7
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

		// Token: 0x17004B71 RID: 19313
		// (get) Token: 0x06016876 RID: 92278 RVA: 0x003469D0 File Offset: 0x00344BD0
		// (set) Token: 0x06016877 RID: 92279 RVA: 0x003469D8 File Offset: 0x00344BD8
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

		// Token: 0x06016878 RID: 92280 RVA: 0x003469E1 File Offset: 0x00344BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleGood);
		}

		// Token: 0x06016879 RID: 92281 RVA: 0x003469EF File Offset: 0x00344BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleGood other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Result == other.Result && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601687A RID: 92282 RVA: 0x00346A30 File Offset: 0x00344C30
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

		// Token: 0x0601687B RID: 92283 RVA: 0x00346A8E File Offset: 0x00344C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601687C RID: 92284 RVA: 0x00346A9B File Offset: 0x00344C9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601687D RID: 92285 RVA: 0x00346AA4 File Offset: 0x00344CA4
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

		// Token: 0x0601687E RID: 92286 RVA: 0x00346AFC File Offset: 0x00344CFC
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

		// Token: 0x0601687F RID: 92287 RVA: 0x00346B54 File Offset: 0x00344D54
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

		// Token: 0x06016880 RID: 92288 RVA: 0x00346BA4 File Offset: 0x00344DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016881 RID: 92289 RVA: 0x00346BB0 File Offset: 0x00344DB0
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

		// Token: 0x0400870D RID: 34573
		private static readonly MessageParser<RoleGood> _parser = new MessageParser<RoleGood>(() => new RoleGood());

		// Token: 0x0400870E RID: 34574
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400870F RID: 34575
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04008710 RID: 34576
		private int roleId_;

		// Token: 0x04008711 RID: 34577
		public const int ResultFieldNumber = 2;

		// Token: 0x04008712 RID: 34578
		private RoleSettleResult result_;
	}
}
