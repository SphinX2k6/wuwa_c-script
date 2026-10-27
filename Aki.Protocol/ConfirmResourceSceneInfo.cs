using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002D4 RID: 724
	public sealed class ConfirmResourceSceneInfo : IMessage<ConfirmResourceSceneInfo>, IMessage, IEquatable<ConfirmResourceSceneInfo>, IDeepCloneable<ConfirmResourceSceneInfo>, IBufferMessage
	{
		// Token: 0x06004A1B RID: 18971 RVA: 0x000B51D6 File Offset: 0x000B33D6
		[NullableContext(1)]
		public static ConfirmResourceSceneInfo Create()
		{
			return new ConfirmResourceSceneInfo();
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x06004A1C RID: 18972 RVA: 0x000B51DD File Offset: 0x000B33DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ConfirmResourceSceneInfo> Parser
		{
			get
			{
				return ConfirmResourceSceneInfo._parser;
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x06004A1D RID: 18973 RVA: 0x000B51E4 File Offset: 0x000B33E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x06004A1E RID: 18974 RVA: 0x000B51E7 File Offset: 0x000B33E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConfirmResourceSceneInfo.Descriptor;
			}
		}

		// Token: 0x06004A1F RID: 18975 RVA: 0x000B51EE File Offset: 0x000B33EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmResourceSceneInfo()
		{
		}

		// Token: 0x06004A20 RID: 18976 RVA: 0x000B51F8 File Offset: 0x000B33F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmResourceSceneInfo(ConfirmResourceSceneInfo other) : this()
		{
			this.instanceId_ = other.instanceId_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A21 RID: 18977 RVA: 0x000B5244 File Offset: 0x000B3444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmResourceSceneInfo Clone()
		{
			return new ConfirmResourceSceneInfo(this);
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x06004A22 RID: 18978 RVA: 0x000B524C File Offset: 0x000B344C
		// (set) Token: 0x06004A23 RID: 18979 RVA: 0x000B5254 File Offset: 0x000B3454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstanceId
		{
			get
			{
				return this.instanceId_;
			}
			set
			{
				this.instanceId_ = value;
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x06004A24 RID: 18980 RVA: 0x000B525D File Offset: 0x000B345D
		// (set) Token: 0x06004A25 RID: 18981 RVA: 0x000B5265 File Offset: 0x000B3465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x06004A26 RID: 18982 RVA: 0x000B526E File Offset: 0x000B346E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConfirmResourceSceneInfo);
		}

		// Token: 0x06004A27 RID: 18983 RVA: 0x000B527C File Offset: 0x000B347C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConfirmResourceSceneInfo other)
		{
			return other != null && (other == this || (this.InstanceId == other.InstanceId && object.Equals(this.Location, other.Location) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004A28 RID: 18984 RVA: 0x000B52CC File Offset: 0x000B34CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstanceId != 0)
			{
				num ^= this.InstanceId.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004A29 RID: 18985 RVA: 0x000B5321 File Offset: 0x000B3521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004A2A RID: 18986 RVA: 0x000B532E File Offset: 0x000B352E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A2B RID: 18987 RVA: 0x000B5338 File Offset: 0x000B3538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstanceId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstanceId);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Location);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004A2C RID: 18988 RVA: 0x000B5390 File Offset: 0x000B3590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstanceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstanceId);
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004A2D RID: 18989 RVA: 0x000B53E8 File Offset: 0x000B35E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConfirmResourceSceneInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstanceId != 0)
			{
				this.InstanceId = other.InstanceId;
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new Vector();
				}
				this.Location.MergeFrom(other.Location);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004A2E RID: 18990 RVA: 0x000B5450 File Offset: 0x000B3650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A2F RID: 18991 RVA: 0x000B545C File Offset: 0x000B365C
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
						if (this.location_ == null)
						{
							this.Location = new Vector();
						}
						input.ReadMessage(this.Location);
					}
				}
				else
				{
					this.InstanceId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003062 RID: 12386
		private static readonly MessageParser<ConfirmResourceSceneInfo> _parser = new MessageParser<ConfirmResourceSceneInfo>(() => new ConfirmResourceSceneInfo());

		// Token: 0x04003063 RID: 12387
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003064 RID: 12388
		public const int InstanceIdFieldNumber = 1;

		// Token: 0x04003065 RID: 12389
		private int instanceId_;

		// Token: 0x04003066 RID: 12390
		public const int LocationFieldNumber = 2;

		// Token: 0x04003067 RID: 12391
		private Vector location_;
	}
}
