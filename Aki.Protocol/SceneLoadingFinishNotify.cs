using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200117C RID: 4476
	[NetMessage(EMessageId.SceneLoadingFinishNotify)]
	public sealed class SceneLoadingFinishNotify : IMessage<SceneLoadingFinishNotify>, IMessage, IEquatable<SceneLoadingFinishNotify>, IDeepCloneable<SceneLoadingFinishNotify>, IBufferMessage
	{
		// Token: 0x06017DB9 RID: 97721 RVA: 0x00377005 File Offset: 0x00375205
		[NullableContext(1)]
		public static SceneLoadingFinishNotify Create()
		{
			return new SceneLoadingFinishNotify();
		}

		// Token: 0x17005023 RID: 20515
		// (get) Token: 0x06017DBA RID: 97722 RVA: 0x0037700C File Offset: 0x0037520C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005024 RID: 20516
		// (get) Token: 0x06017DBB RID: 97723 RVA: 0x0037700F File Offset: 0x0037520F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneLoadingFinishNotify.Descriptor;
			}
		}

		// Token: 0x06017DBC RID: 97724 RVA: 0x00377016 File Offset: 0x00375216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingFinishNotify()
		{
		}

		// Token: 0x06017DBD RID: 97725 RVA: 0x0037701E File Offset: 0x0037521E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingFinishNotify(SceneLoadingFinishNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017DBE RID: 97726 RVA: 0x00377043 File Offset: 0x00375243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingFinishNotify Clone()
		{
			return new SceneLoadingFinishNotify(this);
		}

		// Token: 0x17005025 RID: 20517
		// (get) Token: 0x06017DBF RID: 97727 RVA: 0x0037704B File Offset: 0x0037524B
		// (set) Token: 0x06017DC0 RID: 97728 RVA: 0x00377053 File Offset: 0x00375253
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

		// Token: 0x06017DC1 RID: 97729 RVA: 0x0037705C File Offset: 0x0037525C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneLoadingFinishNotify);
		}

		// Token: 0x06017DC2 RID: 97730 RVA: 0x0037706A File Offset: 0x0037526A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneLoadingFinishNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017DC3 RID: 97731 RVA: 0x00377098 File Offset: 0x00375298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017DC4 RID: 97732 RVA: 0x003770D7 File Offset: 0x003752D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017DC5 RID: 97733 RVA: 0x003770E4 File Offset: 0x003752E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017DC6 RID: 97734 RVA: 0x003770ED File Offset: 0x003752ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017DC7 RID: 97735 RVA: 0x00377120 File Offset: 0x00375320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017DC8 RID: 97736 RVA: 0x0037715E File Offset: 0x0037535E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneLoadingFinishNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017DC9 RID: 97737 RVA: 0x0037718F File Offset: 0x0037538F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017DCA RID: 97738 RVA: 0x00377198 File Offset: 0x00375398
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008D67 RID: 36199
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D68 RID: 36200
		public const int PlayerIdFieldNumber = 15;

		// Token: 0x04008D69 RID: 36201
		private int playerId_;
	}
}
