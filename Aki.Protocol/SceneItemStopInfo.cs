using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011B3 RID: 4531
	public sealed class SceneItemStopInfo : IMessage<SceneItemStopInfo>, IMessage, IEquatable<SceneItemStopInfo>, IDeepCloneable<SceneItemStopInfo>, IBufferMessage
	{
		// Token: 0x0601831E RID: 99102 RVA: 0x00385BB1 File Offset: 0x00383DB1
		[NullableContext(1)]
		public static SceneItemStopInfo Create()
		{
			return new SceneItemStopInfo();
		}

		// Token: 0x17005183 RID: 20867
		// (get) Token: 0x0601831F RID: 99103 RVA: 0x00385BB8 File Offset: 0x00383DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneItemStopInfo> Parser
		{
			get
			{
				return SceneItemStopInfo._parser;
			}
		}

		// Token: 0x17005184 RID: 20868
		// (get) Token: 0x06018320 RID: 99104 RVA: 0x00385BBF File Offset: 0x00383DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005185 RID: 20869
		// (get) Token: 0x06018321 RID: 99105 RVA: 0x00385BC2 File Offset: 0x00383DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemStopInfo.Descriptor;
			}
		}

		// Token: 0x06018322 RID: 99106 RVA: 0x00385BC9 File Offset: 0x00383DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStopInfo()
		{
		}

		// Token: 0x06018323 RID: 99107 RVA: 0x00385BD4 File Offset: 0x00383DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStopInfo(SceneItemStopInfo other) : this()
		{
			this.entityId_ = other.entityId_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018324 RID: 99108 RVA: 0x00385C20 File Offset: 0x00383E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStopInfo Clone()
		{
			return new SceneItemStopInfo(this);
		}

		// Token: 0x17005186 RID: 20870
		// (get) Token: 0x06018325 RID: 99109 RVA: 0x00385C28 File Offset: 0x00383E28
		// (set) Token: 0x06018326 RID: 99110 RVA: 0x00385C30 File Offset: 0x00383E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17005187 RID: 20871
		// (get) Token: 0x06018327 RID: 99111 RVA: 0x00385C39 File Offset: 0x00383E39
		// (set) Token: 0x06018328 RID: 99112 RVA: 0x00385C41 File Offset: 0x00383E41
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

		// Token: 0x06018329 RID: 99113 RVA: 0x00385C4A File Offset: 0x00383E4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemStopInfo);
		}

		// Token: 0x0601832A RID: 99114 RVA: 0x00385C58 File Offset: 0x00383E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemStopInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.Location, other.Location) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601832B RID: 99115 RVA: 0x00385CA8 File Offset: 0x00383EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
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

		// Token: 0x0601832C RID: 99116 RVA: 0x00385CFD File Offset: 0x00383EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601832D RID: 99117 RVA: 0x00385D0A File Offset: 0x00383F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601832E RID: 99118 RVA: 0x00385D14 File Offset: 0x00383F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
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

		// Token: 0x0601832F RID: 99119 RVA: 0x00385D6C File Offset: 0x00383F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
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

		// Token: 0x06018330 RID: 99120 RVA: 0x00385DC4 File Offset: 0x00383FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemStopInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
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

		// Token: 0x06018331 RID: 99121 RVA: 0x00385E2C File Offset: 0x0038402C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018332 RID: 99122 RVA: 0x00385E38 File Offset: 0x00384038
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008FEB RID: 36843
		private static readonly MessageParser<SceneItemStopInfo> _parser = new MessageParser<SceneItemStopInfo>(() => new SceneItemStopInfo());

		// Token: 0x04008FEC RID: 36844
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FED RID: 36845
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04008FEE RID: 36846
		private long entityId_;

		// Token: 0x04008FEF RID: 36847
		public const int LocationFieldNumber = 2;

		// Token: 0x04008FF0 RID: 36848
		private Vector location_;
	}
}
