using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200117D RID: 4477
	[NetMessage(EMessageId.SceneLoadingFinishRequest)]
	public sealed class SceneLoadingFinishRequest : IMessage<SceneLoadingFinishRequest>, IMessage, IEquatable<SceneLoadingFinishRequest>, IDeepCloneable<SceneLoadingFinishRequest>, IBufferMessage
	{
		// Token: 0x06017DCB RID: 97739 RVA: 0x003771DD File Offset: 0x003753DD
		[NullableContext(1)]
		public static SceneLoadingFinishRequest Create()
		{
			return new SceneLoadingFinishRequest();
		}

		// Token: 0x17005026 RID: 20518
		// (get) Token: 0x06017DCC RID: 97740 RVA: 0x003771E4 File Offset: 0x003753E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005027 RID: 20519
		// (get) Token: 0x06017DCD RID: 97741 RVA: 0x003771E7 File Offset: 0x003753E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneLoadingFinishRequest.Descriptor;
			}
		}

		// Token: 0x06017DCE RID: 97742 RVA: 0x003771EE File Offset: 0x003753EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingFinishRequest()
		{
		}

		// Token: 0x06017DCF RID: 97743 RVA: 0x00377201 File Offset: 0x00375401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingFinishRequest(SceneLoadingFinishRequest other) : this()
		{
			this.sceneId_ = other.sceneId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017DD0 RID: 97744 RVA: 0x00377226 File Offset: 0x00375426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingFinishRequest Clone()
		{
			return new SceneLoadingFinishRequest(this);
		}

		// Token: 0x17005028 RID: 20520
		// (get) Token: 0x06017DD1 RID: 97745 RVA: 0x0037722E File Offset: 0x0037542E
		// (set) Token: 0x06017DD2 RID: 97746 RVA: 0x00377236 File Offset: 0x00375436
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

		// Token: 0x06017DD3 RID: 97747 RVA: 0x00377249 File Offset: 0x00375449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneLoadingFinishRequest);
		}

		// Token: 0x06017DD4 RID: 97748 RVA: 0x00377257 File Offset: 0x00375457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneLoadingFinishRequest other)
		{
			return other != null && (other == this || (!(this.SceneId != other.SceneId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017DD5 RID: 97749 RVA: 0x0037728C File Offset: 0x0037548C
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

		// Token: 0x06017DD6 RID: 97750 RVA: 0x003772CD File Offset: 0x003754CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017DD7 RID: 97751 RVA: 0x003772DA File Offset: 0x003754DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017DD8 RID: 97752 RVA: 0x003772E3 File Offset: 0x003754E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SceneId.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.SceneId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017DD9 RID: 97753 RVA: 0x0037731C File Offset: 0x0037551C
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

		// Token: 0x06017DDA RID: 97754 RVA: 0x0037735F File Offset: 0x0037555F
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

		// Token: 0x06017DDB RID: 97755 RVA: 0x00377395 File Offset: 0x00375595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017DDC RID: 97756 RVA: 0x003773A0 File Offset: 0x003755A0
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
					this.SceneId = input.ReadString();
				}
			}
		}

		// Token: 0x04008D6A RID: 36202
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D6B RID: 36203
		public const int SceneIdFieldNumber = 8;

		// Token: 0x04008D6C RID: 36204
		private string sceneId_ = "";
	}
}
