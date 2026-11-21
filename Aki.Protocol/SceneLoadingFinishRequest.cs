using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011B7 RID: 4535
	[NetMessage(EMessageId.SceneLoadingFinishRequest)]
	public sealed class SceneLoadingFinishRequest : IMessage<SceneLoadingFinishRequest>, IMessage, IEquatable<SceneLoadingFinishRequest>, IDeepCloneable<SceneLoadingFinishRequest>, IBufferMessage
	{
		// Token: 0x0601836C RID: 99180 RVA: 0x00386521 File Offset: 0x00384721
		[NullableContext(1)]
		public static SceneLoadingFinishRequest Create()
		{
			return new SceneLoadingFinishRequest();
		}

		// Token: 0x17005192 RID: 20882
		// (get) Token: 0x0601836D RID: 99181 RVA: 0x00386528 File Offset: 0x00384728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005193 RID: 20883
		// (get) Token: 0x0601836E RID: 99182 RVA: 0x0038652B File Offset: 0x0038472B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneLoadingFinishRequest.Descriptor;
			}
		}

		// Token: 0x0601836F RID: 99183 RVA: 0x00386532 File Offset: 0x00384732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingFinishRequest()
		{
		}

		// Token: 0x06018370 RID: 99184 RVA: 0x00386545 File Offset: 0x00384745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingFinishRequest(SceneLoadingFinishRequest other) : this()
		{
			this.sceneId_ = other.sceneId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018371 RID: 99185 RVA: 0x0038656A File Offset: 0x0038476A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingFinishRequest Clone()
		{
			return new SceneLoadingFinishRequest(this);
		}

		// Token: 0x17005194 RID: 20884
		// (get) Token: 0x06018372 RID: 99186 RVA: 0x00386572 File Offset: 0x00384772
		// (set) Token: 0x06018373 RID: 99187 RVA: 0x0038657A File Offset: 0x0038477A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SceneId
		{
			get
			{
				return this.sceneId_;
			}
			set
			{
				this.sceneId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06018374 RID: 99188 RVA: 0x0038658D File Offset: 0x0038478D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneLoadingFinishRequest);
		}

		// Token: 0x06018375 RID: 99189 RVA: 0x0038659B File Offset: 0x0038479B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneLoadingFinishRequest other)
		{
			return other != null && (other == this || (!(this.SceneId != other.SceneId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018376 RID: 99190 RVA: 0x003865D0 File Offset: 0x003847D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SceneId.Length != 0)
			{
				num ^= this.SceneId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018377 RID: 99191 RVA: 0x00386611 File Offset: 0x00384811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018378 RID: 99192 RVA: 0x0038661E File Offset: 0x0038481E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018379 RID: 99193 RVA: 0x00386627 File Offset: 0x00384827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SceneId.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.SceneId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601837A RID: 99194 RVA: 0x00386660 File Offset: 0x00384860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SceneId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SceneId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601837B RID: 99195 RVA: 0x003866A3 File Offset: 0x003848A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneLoadingFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SceneId.Length != 0)
			{
				this.SceneId = other.SceneId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601837C RID: 99196 RVA: 0x003866D9 File Offset: 0x003848D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601837D RID: 99197 RVA: 0x003866E4 File Offset: 0x003848E4
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SceneId = input.ReadString();
				}
			}
		}

		// Token: 0x04008FFD RID: 36861
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FFE RID: 36862
		public const int SceneIdFieldNumber = 2;

		// Token: 0x04008FFF RID: 36863
		private string sceneId_ = "";
	}
}
