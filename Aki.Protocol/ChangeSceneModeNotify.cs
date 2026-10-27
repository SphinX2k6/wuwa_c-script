using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200025B RID: 603
	[NetMessage(EMessageId.ChangeSceneModeNotify)]
	public sealed class ChangeSceneModeNotify : IMessage<ChangeSceneModeNotify>, IMessage, IEquatable<ChangeSceneModeNotify>, IDeepCloneable<ChangeSceneModeNotify>, IBufferMessage
	{
		// Token: 0x06003FF3 RID: 16371 RVA: 0x0009D13A File Offset: 0x0009B33A
		[NullableContext(1)]
		public static ChangeSceneModeNotify Create()
		{
			return new ChangeSceneModeNotify();
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06003FF4 RID: 16372 RVA: 0x0009D141 File Offset: 0x0009B341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06003FF5 RID: 16373 RVA: 0x0009D144 File Offset: 0x0009B344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeSceneModeNotify.Descriptor;
			}
		}

		// Token: 0x06003FF6 RID: 16374 RVA: 0x0009D14B File Offset: 0x0009B34B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSceneModeNotify()
		{
		}

		// Token: 0x06003FF7 RID: 16375 RVA: 0x0009D15E File Offset: 0x0009B35E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSceneModeNotify(ChangeSceneModeNotify other) : this()
		{
			this.sceneId_ = other.sceneId_;
			this.mode_ = other.mode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003FF8 RID: 16376 RVA: 0x0009D18F File Offset: 0x0009B38F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSceneModeNotify Clone()
		{
			return new ChangeSceneModeNotify(this);
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06003FF9 RID: 16377 RVA: 0x0009D197 File Offset: 0x0009B397
		// (set) Token: 0x06003FFA RID: 16378 RVA: 0x0009D19F File Offset: 0x0009B39F
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

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06003FFB RID: 16379 RVA: 0x0009D1B2 File Offset: 0x0009B3B2
		// (set) Token: 0x06003FFC RID: 16380 RVA: 0x0009D1BA File Offset: 0x0009B3BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMode Mode
		{
			get
			{
				return this.mode_;
			}
			set
			{
				this.mode_ = value;
			}
		}

		// Token: 0x06003FFD RID: 16381 RVA: 0x0009D1C3 File Offset: 0x0009B3C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeSceneModeNotify);
		}

		// Token: 0x06003FFE RID: 16382 RVA: 0x0009D1D4 File Offset: 0x0009B3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeSceneModeNotify other)
		{
			return other != null && (other == this || (!(this.SceneId != other.SceneId) && this.Mode == other.Mode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003FFF RID: 16383 RVA: 0x0009D224 File Offset: 0x0009B424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SceneId.Length != 0)
			{
				num ^= this.SceneId.GetHashCode();
			}
			if (this.Mode != SceneMode.Single)
			{
				num ^= this.Mode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004000 RID: 16384 RVA: 0x0009D284 File Offset: 0x0009B484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x0009D291 File Offset: 0x0009B491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x0009D29C File Offset: 0x0009B49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Mode != SceneMode.Single)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Mode);
			}
			if (this.SceneId.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.SceneId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004003 RID: 16387 RVA: 0x0009D2FC File Offset: 0x0009B4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SceneId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SceneId);
			}
			if (this.Mode != SceneMode.Single)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Mode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004004 RID: 16388 RVA: 0x0009D358 File Offset: 0x0009B558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeSceneModeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SceneId.Length != 0)
			{
				this.SceneId = other.SceneId;
			}
			if (other.Mode != SceneMode.Single)
			{
				this.Mode = other.Mode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004005 RID: 16389 RVA: 0x0009D3AD File Offset: 0x0009B5AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004006 RID: 16390 RVA: 0x0009D3B8 File Offset: 0x0009B5B8
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
				if (num != 64U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SceneId = input.ReadString();
					}
				}
				else
				{
					this.Mode = (SceneMode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002D3D RID: 11581
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D3E RID: 11582
		public const int SceneIdFieldNumber = 10;

		// Token: 0x04002D3F RID: 11583
		private string sceneId_ = "";

		// Token: 0x04002D40 RID: 11584
		public const int ModeFieldNumber = 8;

		// Token: 0x04002D41 RID: 11585
		private SceneMode mode_;
	}
}
