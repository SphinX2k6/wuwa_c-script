using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000573 RID: 1395
	[NetMessage(EMessageId.FishingSkillTeleportRequest)]
	public sealed class FishingSkillTeleportRequest : IMessage<FishingSkillTeleportRequest>, IMessage, IEquatable<FishingSkillTeleportRequest>, IDeepCloneable<FishingSkillTeleportRequest>, IBufferMessage
	{
		// Token: 0x060081FC RID: 33276 RVA: 0x00139D4C File Offset: 0x00137F4C
		[NullableContext(1)]
		public static FishingSkillTeleportRequest Create()
		{
			return new FishingSkillTeleportRequest();
		}

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x060081FD RID: 33277 RVA: 0x00139D53 File Offset: 0x00137F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x060081FE RID: 33278 RVA: 0x00139D56 File Offset: 0x00137F56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSkillTeleportRequest.Descriptor;
			}
		}

		// Token: 0x060081FF RID: 33279 RVA: 0x00139D5D File Offset: 0x00137F5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillTeleportRequest()
		{
		}

		// Token: 0x06008200 RID: 33280 RVA: 0x00139D65 File Offset: 0x00137F65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillTeleportRequest(FishingSkillTeleportRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008201 RID: 33281 RVA: 0x00139D7E File Offset: 0x00137F7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillTeleportRequest Clone()
		{
			return new FishingSkillTeleportRequest(this);
		}

		// Token: 0x06008202 RID: 33282 RVA: 0x00139D86 File Offset: 0x00137F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSkillTeleportRequest);
		}

		// Token: 0x06008203 RID: 33283 RVA: 0x00139D94 File Offset: 0x00137F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSkillTeleportRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06008204 RID: 33284 RVA: 0x00139DB4 File Offset: 0x00137FB4
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

		// Token: 0x06008205 RID: 33285 RVA: 0x00139DDA File Offset: 0x00137FDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008206 RID: 33286 RVA: 0x00139DE7 File Offset: 0x00137FE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008207 RID: 33287 RVA: 0x00139DF0 File Offset: 0x00137FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008208 RID: 33288 RVA: 0x00139E08 File Offset: 0x00138008
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

		// Token: 0x06008209 RID: 33289 RVA: 0x00139E2E File Offset: 0x0013802E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSkillTeleportRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600820A RID: 33290 RVA: 0x00139E4B File Offset: 0x0013804B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600820B RID: 33291 RVA: 0x00139E54 File Offset: 0x00138054
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

		// Token: 0x0400416E RID: 16750
		private UnknownFieldSet _unknownFields;
	}
}
