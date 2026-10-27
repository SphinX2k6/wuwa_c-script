using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012D6 RID: 4822
	[NetMessage(EMessageId.SurvivorsOpDataForceChangeNotify)]
	public sealed class SurvivorsOpDataForceChangeNotify : IMessage<SurvivorsOpDataForceChangeNotify>, IMessage, IEquatable<SurvivorsOpDataForceChangeNotify>, IDeepCloneable<SurvivorsOpDataForceChangeNotify>, IBufferMessage
	{
		// Token: 0x06019A77 RID: 105079 RVA: 0x003BAD5B File Offset: 0x003B8F5B
		[NullableContext(1)]
		public static SurvivorsOpDataForceChangeNotify Create()
		{
			return new SurvivorsOpDataForceChangeNotify();
		}

		// Token: 0x1700568D RID: 22157
		// (get) Token: 0x06019A78 RID: 105080 RVA: 0x003BAD62 File Offset: 0x003B8F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700568E RID: 22158
		// (get) Token: 0x06019A79 RID: 105081 RVA: 0x003BAD65 File Offset: 0x003B8F65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsOpDataForceChangeNotify.Descriptor;
			}
		}

		// Token: 0x06019A7A RID: 105082 RVA: 0x003BAD6C File Offset: 0x003B8F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpDataForceChangeNotify()
		{
		}

		// Token: 0x06019A7B RID: 105083 RVA: 0x003BAD74 File Offset: 0x003B8F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpDataForceChangeNotify(SurvivorsOpDataForceChangeNotify other) : this()
		{
			this.forceIncId_ = other.forceIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019A7C RID: 105084 RVA: 0x003BAD99 File Offset: 0x003B8F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpDataForceChangeNotify Clone()
		{
			return new SurvivorsOpDataForceChangeNotify(this);
		}

		// Token: 0x1700568F RID: 22159
		// (get) Token: 0x06019A7D RID: 105085 RVA: 0x003BADA1 File Offset: 0x003B8FA1
		// (set) Token: 0x06019A7E RID: 105086 RVA: 0x003BADA9 File Offset: 0x003B8FA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ForceIncId
		{
			get
			{
				return this.forceIncId_;
			}
			set
			{
				this.forceIncId_ = value;
			}
		}

		// Token: 0x06019A7F RID: 105087 RVA: 0x003BADB2 File Offset: 0x003B8FB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsOpDataForceChangeNotify);
		}

		// Token: 0x06019A80 RID: 105088 RVA: 0x003BADC0 File Offset: 0x003B8FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsOpDataForceChangeNotify other)
		{
			return other != null && (other == this || (this.ForceIncId == other.ForceIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019A81 RID: 105089 RVA: 0x003BADF0 File Offset: 0x003B8FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ForceIncId != 0)
			{
				num ^= this.ForceIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019A82 RID: 105090 RVA: 0x003BAE2F File Offset: 0x003B902F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019A83 RID: 105091 RVA: 0x003BAE3C File Offset: 0x003B903C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019A84 RID: 105092 RVA: 0x003BAE45 File Offset: 0x003B9045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ForceIncId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ForceIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019A85 RID: 105093 RVA: 0x003BAE78 File Offset: 0x003B9078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ForceIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ForceIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019A86 RID: 105094 RVA: 0x003BAEB6 File Offset: 0x003B90B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsOpDataForceChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ForceIncId != 0)
			{
				this.ForceIncId = other.ForceIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019A87 RID: 105095 RVA: 0x003BAEE7 File Offset: 0x003B90E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019A88 RID: 105096 RVA: 0x003BAEF0 File Offset: 0x003B90F0
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ForceIncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009665 RID: 38501
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009666 RID: 38502
		public const int ForceIncIdFieldNumber = 9;

		// Token: 0x04009667 RID: 38503
		private int forceIncId_;
	}
}
