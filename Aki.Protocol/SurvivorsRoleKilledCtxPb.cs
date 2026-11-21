using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001351 RID: 4945
	public sealed class SurvivorsRoleKilledCtxPb : IMessage<SurvivorsRoleKilledCtxPb>, IMessage, IEquatable<SurvivorsRoleKilledCtxPb>, IDeepCloneable<SurvivorsRoleKilledCtxPb>, IBufferMessage
	{
		// Token: 0x0601A59A RID: 107930 RVA: 0x003D7424 File Offset: 0x003D5624
		[NullableContext(1)]
		public static SurvivorsRoleKilledCtxPb Create()
		{
			return new SurvivorsRoleKilledCtxPb();
		}

		// Token: 0x1700593E RID: 22846
		// (get) Token: 0x0601A59B RID: 107931 RVA: 0x003D742B File Offset: 0x003D562B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700593F RID: 22847
		// (get) Token: 0x0601A59C RID: 107932 RVA: 0x003D742E File Offset: 0x003D562E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsRoleKilledCtxPb.Descriptor;
			}
		}

		// Token: 0x0601A59D RID: 107933 RVA: 0x003D7435 File Offset: 0x003D5635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRoleKilledCtxPb()
		{
		}

		// Token: 0x0601A59E RID: 107934 RVA: 0x003D743D File Offset: 0x003D563D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRoleKilledCtxPb(SurvivorsRoleKilledCtxPb other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A59F RID: 107935 RVA: 0x003D7456 File Offset: 0x003D5656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRoleKilledCtxPb Clone()
		{
			return new SurvivorsRoleKilledCtxPb(this);
		}

		// Token: 0x0601A5A0 RID: 107936 RVA: 0x003D745E File Offset: 0x003D565E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsRoleKilledCtxPb);
		}

		// Token: 0x0601A5A1 RID: 107937 RVA: 0x003D746C File Offset: 0x003D566C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsRoleKilledCtxPb other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601A5A2 RID: 107938 RVA: 0x003D748C File Offset: 0x003D568C
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

		// Token: 0x0601A5A3 RID: 107939 RVA: 0x003D74B2 File Offset: 0x003D56B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A5A4 RID: 107940 RVA: 0x003D74BF File Offset: 0x003D56BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A5A5 RID: 107941 RVA: 0x003D74C8 File Offset: 0x003D56C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A5A6 RID: 107942 RVA: 0x003D74E0 File Offset: 0x003D56E0
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

		// Token: 0x0601A5A7 RID: 107943 RVA: 0x003D7506 File Offset: 0x003D5706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsRoleKilledCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A5A8 RID: 107944 RVA: 0x003D7523 File Offset: 0x003D5723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A5A9 RID: 107945 RVA: 0x003D752C File Offset: 0x003D572C
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

		// Token: 0x04009AD2 RID: 39634
		private UnknownFieldSet _unknownFields;
	}
}
