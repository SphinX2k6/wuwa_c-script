using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001157 RID: 4439
	[NetMessage(EMessageId.SceneGroupDataAndCurFormationEntityRequest)]
	public sealed class SceneGroupDataAndCurFormationEntityRequest : IMessage<SceneGroupDataAndCurFormationEntityRequest>, IMessage, IEquatable<SceneGroupDataAndCurFormationEntityRequest>, IDeepCloneable<SceneGroupDataAndCurFormationEntityRequest>, IBufferMessage
	{
		// Token: 0x06017A95 RID: 96917 RVA: 0x0036F348 File Offset: 0x0036D548
		[NullableContext(1)]
		public static SceneGroupDataAndCurFormationEntityRequest Create()
		{
			return new SceneGroupDataAndCurFormationEntityRequest();
		}

		// Token: 0x17004F69 RID: 20329
		// (get) Token: 0x06017A96 RID: 96918 RVA: 0x0036F34F File Offset: 0x0036D54F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F6A RID: 20330
		// (get) Token: 0x06017A97 RID: 96919 RVA: 0x0036F352 File Offset: 0x0036D552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneGroupDataAndCurFormationEntityRequest.Descriptor;
			}
		}

		// Token: 0x06017A98 RID: 96920 RVA: 0x0036F359 File Offset: 0x0036D559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGroupDataAndCurFormationEntityRequest()
		{
		}

		// Token: 0x06017A99 RID: 96921 RVA: 0x0036F361 File Offset: 0x0036D561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGroupDataAndCurFormationEntityRequest(SceneGroupDataAndCurFormationEntityRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017A9A RID: 96922 RVA: 0x0036F37A File Offset: 0x0036D57A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGroupDataAndCurFormationEntityRequest Clone()
		{
			return new SceneGroupDataAndCurFormationEntityRequest(this);
		}

		// Token: 0x06017A9B RID: 96923 RVA: 0x0036F382 File Offset: 0x0036D582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneGroupDataAndCurFormationEntityRequest);
		}

		// Token: 0x06017A9C RID: 96924 RVA: 0x0036F390 File Offset: 0x0036D590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneGroupDataAndCurFormationEntityRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06017A9D RID: 96925 RVA: 0x0036F3B0 File Offset: 0x0036D5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017A9E RID: 96926 RVA: 0x0036F3D6 File Offset: 0x0036D5D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017A9F RID: 96927 RVA: 0x0036F3E3 File Offset: 0x0036D5E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017AA0 RID: 96928 RVA: 0x0036F3EC File Offset: 0x0036D5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017AA1 RID: 96929 RVA: 0x0036F404 File Offset: 0x0036D604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017AA2 RID: 96930 RVA: 0x0036F42A File Offset: 0x0036D62A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneGroupDataAndCurFormationEntityRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017AA3 RID: 96931 RVA: 0x0036F447 File Offset: 0x0036D647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017AA4 RID: 96932 RVA: 0x0036F450 File Offset: 0x0036D650
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008C67 RID: 35943
		private UnknownFieldSet _unknownFields;
	}
}
