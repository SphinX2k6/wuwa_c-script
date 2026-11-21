using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200117C RID: 4476
	[NetMessage(EMessageId.SceneAreaStateNotify)]
	public sealed class SceneAreaStateNotify : IMessage<SceneAreaStateNotify>, IMessage, IEquatable<SceneAreaStateNotify>, IDeepCloneable<SceneAreaStateNotify>, IBufferMessage
	{
		// Token: 0x06017E8D RID: 97933 RVA: 0x0037AD2B File Offset: 0x00378F2B
		[NullableContext(1)]
		public static SceneAreaStateNotify Create()
		{
			return new SceneAreaStateNotify();
		}

		// Token: 0x1700507B RID: 20603
		// (get) Token: 0x06017E8E RID: 97934 RVA: 0x0037AD32 File Offset: 0x00378F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700507C RID: 20604
		// (get) Token: 0x06017E8F RID: 97935 RVA: 0x0037AD35 File Offset: 0x00378F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneAreaStateNotify.Descriptor;
			}
		}

		// Token: 0x06017E90 RID: 97936 RVA: 0x0037AD3C File Offset: 0x00378F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneAreaStateNotify()
		{
		}

		// Token: 0x06017E91 RID: 97937 RVA: 0x0037AD44 File Offset: 0x00378F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneAreaStateNotify(SceneAreaStateNotify other) : this()
		{
			this.areaState_ = ((other.areaState_ != null) ? other.areaState_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017E92 RID: 97938 RVA: 0x0037AD79 File Offset: 0x00378F79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneAreaStateNotify Clone()
		{
			return new SceneAreaStateNotify(this);
		}

		// Token: 0x1700507D RID: 20605
		// (get) Token: 0x06017E93 RID: 97939 RVA: 0x0037AD81 File Offset: 0x00378F81
		// (set) Token: 0x06017E94 RID: 97940 RVA: 0x0037AD89 File Offset: 0x00378F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneAreaState AreaState
		{
			get
			{
				return this.areaState_;
			}
			set
			{
				this.areaState_ = value;
			}
		}

		// Token: 0x06017E95 RID: 97941 RVA: 0x0037AD92 File Offset: 0x00378F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneAreaStateNotify);
		}

		// Token: 0x06017E96 RID: 97942 RVA: 0x0037ADA0 File Offset: 0x00378FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneAreaStateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.AreaState, other.AreaState) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017E97 RID: 97943 RVA: 0x0037ADD4 File Offset: 0x00378FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.areaState_ != null)
			{
				num ^= this.AreaState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017E98 RID: 97944 RVA: 0x0037AE10 File Offset: 0x00379010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017E99 RID: 97945 RVA: 0x0037AE1D File Offset: 0x0037901D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017E9A RID: 97946 RVA: 0x0037AE26 File Offset: 0x00379026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.areaState_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.AreaState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017E9B RID: 97947 RVA: 0x0037AE58 File Offset: 0x00379058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.areaState_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AreaState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017E9C RID: 97948 RVA: 0x0037AE98 File Offset: 0x00379098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneAreaStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.areaState_ != null)
			{
				if (this.areaState_ == null)
				{
					this.AreaState = new SceneAreaState();
				}
				this.AreaState.MergeFrom(other.AreaState);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017E9D RID: 97949 RVA: 0x0037AEEC File Offset: 0x003790EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017E9E RID: 97950 RVA: 0x0037AEF8 File Offset: 0x003790F8
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.areaState_ == null)
					{
						this.AreaState = new SceneAreaState();
					}
					input.ReadMessage(this.AreaState);
				}
			}
		}

		// Token: 0x04008E7B RID: 36475
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E7C RID: 36476
		public const int AreaStateFieldNumber = 8;

		// Token: 0x04008E7D RID: 36477
		private SceneAreaState areaState_;
	}
}
